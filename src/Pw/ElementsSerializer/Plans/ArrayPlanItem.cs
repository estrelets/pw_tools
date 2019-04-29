using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Pw.ElementsSerializer.ValueAccessors;

namespace Pw.ElementsSerializer.Plans
{
    public class ArrayPlanItem : ICompositePlanItem
    {
        public IValueAccessor Accessor { get; }
        public Type ArrayType { get; }
        public int Length { get; }
        public IReadOnlyList<IPlanItem> Childs { get; }

        public ArrayPlanItem(IValueAccessor accessor, Type arrayType, IPlanItem[] childs)
        {
            if (!childs.All(c => c.Accessor is ArrayValueAccessor))
                throw new NotSupportedException($"Childs accessor must be {nameof(ArrayValueAccessor)}");

            Accessor = accessor;
            ArrayType = arrayType;
            Childs = childs;
            Length = childs.Length;
        }

        public void Serialize(object obj, Stream stream)
        {
            var array = Accessor.Get(obj);

            foreach (var child in Childs)
            {
                child.Serialize(array, stream);
            }
        }

        public object Deserialize(object obj, Stream stream)
        {
            var array = Activator.CreateInstance(ArrayType, Length);

            foreach (var child in Childs)
            {
                child.Deserialize(array, stream);
            }

            if (Accessor is IValueAssigner setter)
            {
                setter.Set(obj, array);
            }

            return array;
        }

        public override string ToString()
        {
            return ComplexPlanPrinter.Print(this, 0);
        }
    }
}
