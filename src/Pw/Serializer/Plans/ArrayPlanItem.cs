using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Pw.Serializer.Readers;
using Pw.Serializer.ValueAccessors;
using Pw.Serializer.Writers;

namespace Pw.Serializer.Plans
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

        public void Serialize(object obj, IWriter writer, Stream stream)
        {
            var array = Accessor.Get(obj);

            foreach (var child in Childs)
            {
                child.Serialize(array, writer, stream);
            }
        }

        public object Deserialize(object obj, IReader reader, Stream stream)
        {
            var array = Activator.CreateInstance(ArrayType, Length);

            foreach (var child in Childs)
            {
                child.Deserialize(array, reader, stream);
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
