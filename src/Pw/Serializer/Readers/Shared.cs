using System;
using System.IO;
using Pw.Serializer.Plans;
using static System.BitConverter;

namespace Pw.Serializer.Readers
{
    internal static class Shared
    {
        internal static object Read(PrimitivePlanItem primitivePlanItem, Stream stream)
        {
            switch (primitivePlanItem.TypeCode)
            {
                case TypeCode.Byte: return ReadBytes(1)[0];
                case TypeCode.Single: return ToSingle(ReadBytes(4), 0);
                case TypeCode.Int32: return ToInt32(ReadBytes(4), 0);
                case TypeCode.UInt32: return ToUInt32(ReadBytes(4), 0);
                default: throw new NotImplementedException();
            }

            byte[] ReadBytes(int chunkSize)
            {
                var buffer = new byte[chunkSize];
                stream.Read(buffer, 0, chunkSize);
                return buffer;
            }
        }
        
        internal static string Read(StringPlanItem plan, int length, Stream stream)
        {
            var encoding = plan.GetEncoding();
            var bytesLength = plan.CalculateBytesLength(length);

            var textBuffer = new byte[bytesLength];
            stream.Read(textBuffer, 0, bytesLength);

            var value = encoding.GetString(textBuffer);

            if (!plan.IsDynamic)
                value = value.TrimEnd('\0');

            return value;
        }
    }
}
