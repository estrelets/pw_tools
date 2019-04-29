using System;
using System.Collections.Generic;
using System.IO;
using Pw.ElementsSerializer.ValueAccessors;

namespace Pw.ElementsSerializer.Plans
{
    /// <summary>
    /// As Array but unknown size
    /// </summary>
    public class CollectionPlanItem : ICompositePlanItem
    {
        public IPlanItem LengthPlan { get; }
        public IPlanItem ChildPlan { get; }
        public IValueAccessor Accessor { get; }
        public Type ArrayType { get; }
        public IReadOnlyList<IPlanItem> Childs { get; }

        public CollectionPlanItem(IValueAccessor accessor, Type arrayType, IPlanItem childPlan)
        {
            if (!(childPlan.Accessor is RootObject))
                throw new NotSupportedException($"Child plan accessor must be {nameof(RootObject)}");

            Accessor = accessor;
            LengthPlan = PlanBuilder.CreateReadLengthPlan();
            ChildPlan = childPlan;
            ArrayType = arrayType;
            Childs = new[] { LengthPlan, childPlan };
        }

        public void Serialize(object obj, Stream stream)
        {
            var array = (Array)Accessor.Get(obj);
            var length = array.Length;

            LengthPlan.Serialize(length, stream);

            for (int i = 0; i < length; i++)
            {
                var element = array.GetValue(i);
                ChildPlan.Serialize(element, stream);
            }
        }

        public object Deserialize(object obj, Stream stream)
        {
            var length = (int)LengthPlan.Deserialize(obj, stream);
            var array = (Array)Activator.CreateInstance(ArrayType, length);

            for (int i = 0; i < length; i++)
            {
                var element = ChildPlan.Deserialize(null, stream);
                array.SetValue(element, i);
            }

            if (Accessor is IValueAssigner setter)
            {
                setter.Set(obj, array);
            }

            return array;
        }
    }
}
