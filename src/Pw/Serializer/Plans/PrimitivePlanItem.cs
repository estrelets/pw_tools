using System;
using System.IO;
using System.Linq;
using Pw.Serializer.Readers;
using Pw.Serializer.ValueAccessors;
using Pw.Serializer.Writers;

namespace Pw.Serializer.Plans
{
    public class PrimitivePlanItem : IPlanItem
    {
        public TypeCode TypeCode { get; }
        public bool BigEndian { get; }
        public IValueAccessor Accessor { get; }

        public PrimitivePlanItem(IValueAccessor accessor, Type type, bool bigEndian)
        {
            if (!IsPrimitive(type))
            {
                throw new NotSupportedException($"TypeCode {type} is not supported for PrimitivePlanItem");
            }

            Accessor = accessor;
            BigEndian = bigEndian;
            TypeCode = Type.GetTypeCode(type);
        }

        public void Serialize(object obj, IWriter writer, Stream stream)
        {
            var value = Accessor.Get(obj);
            writer.Write(this, value, stream);
        }

        public object Deserialize(object obj, IReader reader, Stream stream)
        {
            object value = reader.Read(this, stream);// ReadValue(stream);

            if (Accessor is IValueAssigner setter)
            {
                setter.Set(obj, value);
            }

            return value;
        }

        public override string ToString()
        {
            return $"{Accessor} => {TypeCode}";
        }

        public static bool IsPrimitive(Type type) => IsPrimitive(System.Type.GetTypeCode(type));
        private static bool IsPrimitive(TypeCode code) => PrimitiveTypeCode.Contains(code);

        private static readonly TypeCode[] PrimitiveTypeCode =
        {
            TypeCode.Boolean,
            TypeCode.Byte,
            TypeCode.Int16,
            TypeCode.Int32,
            TypeCode.Int64,
            TypeCode.UInt16,
            TypeCode.UInt32,
            TypeCode.UInt64,
            TypeCode.Double,
            TypeCode.Single
        };
    }
}
