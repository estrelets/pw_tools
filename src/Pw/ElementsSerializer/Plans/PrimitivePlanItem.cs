using System;
using System.IO;
using System.Linq;
using Pw.ElementsSerializer.ValueAccessors;

namespace Pw.ElementsSerializer.Plans
{
    public class PrimitivePlanItem : IPlanItem
    {
        public TypeCode TypeCode { get; }
        public IValueAccessor Accessor { get; }

        public PrimitivePlanItem(IValueAccessor accessor, Type type)
        {
            if (!IsPrimitive(type))
            {
                throw new NotSupportedException($"TypeCode {type} is not supported for PrimitivePlanItem");
            }

            Accessor = accessor;
            TypeCode = System.Type.GetTypeCode(type);
        }

        public void Serialize(object obj, Stream stream)
        {
            var value = Accessor.Get(obj);
            var buffer = GetBytes(value);
            stream.Write(buffer, 0, buffer.Length);
        }

        public object Deserialize(object obj, Stream stream)
        {
            object value = ReadValue(stream);

            if (Accessor is IValueAssigner setter)
            {
                setter.Set(obj, value);
            }

            return value;
        }

        private object ReadValue(Stream stream)
        {
            switch (TypeCode)
            {
                case TypeCode.Byte: return ReadBytes(1)[0];
                case TypeCode.Single: return BitConverter.ToSingle(ReadBytes(4), 0);
                case TypeCode.Int32: return BitConverter.ToInt32(ReadBytes(4), 0);
                case TypeCode.UInt32: return BitConverter.ToUInt32(ReadBytes(4), 0);
                default: throw new NotImplementedException();
            }

            byte[] ReadBytes(int chunkSize)
            {
                var buffer = new byte[chunkSize];
                stream.Read(buffer, 0, chunkSize);
                return buffer;
            }
        }

        private byte[] GetBytes(object obj)
        {
            switch (TypeCode)
            {
                case TypeCode.Byte: return BitConverter.GetBytes((byte)obj);
                case TypeCode.Single: return BitConverter.GetBytes((float)obj);
                case TypeCode.Int32: return BitConverter.GetBytes((int)obj);
                case TypeCode.UInt32: return BitConverter.GetBytes((uint)obj);
                default: throw new NotImplementedException();
            }
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
