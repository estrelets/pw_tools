using System;
using System.IO;
using Pw.Serializer.Plans;

namespace Pw.Serializer.Writers
{
    internal static class Shared
    {
        internal static void Write(PrimitivePlanItem primitivePlanItem, object value, Stream stream)
        {
            var buffer = GetBytes();
            stream.Write(buffer, 0, buffer.Length);
            
            byte[] GetBytes()
            {
                switch (primitivePlanItem.TypeCode)
                {
                    case TypeCode.Byte: return new []{(byte)value};
                    case TypeCode.Single: return BitConverter.GetBytes((float)value);
                    case TypeCode.Int32: return BitConverter.GetBytes((int)value);
                    case TypeCode.UInt32: return BitConverter.GetBytes((uint)value);
                    default: throw new NotImplementedException();
                }
            }
        }
        
        internal static void Write(StringPlanItem plan, string value, int length, Stream stream)
        {
            var encoding = plan.GetEncoding();
            length = plan.CalculateBytesLength(length);
            var textBuffer = encoding.GetBytes(value);
            Array.Resize(ref textBuffer, length);
            stream.Write(textBuffer, 0, textBuffer.Length);
        }
    }
}
