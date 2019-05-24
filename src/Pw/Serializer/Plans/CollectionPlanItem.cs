using System;
using System.Collections.Generic;
using System.IO;
using Pw.Serializer.Readers;
using Pw.Serializer.ValueAccessors;
using Pw.Serializer.Writers;

namespace Pw.Serializer.Plans
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

        public void Serialize(object obj, IWriter writer, Stream stream)
        {
            var array = (Array)Accessor.Get(obj);
            var length = array.Length;

            LengthPlan.Serialize(length, writer, stream);

            for (int i = 0; i < length; i++)
            {
                var element = array.GetValue(i);
                ChildPlan.Serialize(element, writer, stream);
            }
        }

        public object Deserialize(object obj, IReader reader, Stream stream)
        {
            var length = (int)LengthPlan.Deserialize(obj, reader, stream);
            var array = (Array)Activator.CreateInstance(ArrayType, length);

            for (int i = 0; i < length; i++)
            {
                var element = ChildPlan.Deserialize(null, reader, stream);
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
