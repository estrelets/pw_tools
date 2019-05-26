using System;
using System.IO;
using System.Runtime.InteropServices;
using Pw.Serializer.Plans;
using static System.Buffers.Binary.BinaryPrimitives;

namespace Pw.Serializer.Writers
{
    public class GnetWriter : IWriter
    {
        public void Write(PrimitivePlanItem primitivePlanItem, object value, Stream stream)
        {
            bool needToReverse = primitivePlanItem.BigEndian
                                 && primitivePlanItem.TypeCode != TypeCode.Byte
                                 && primitivePlanItem.TypeCode != TypeCode.Single;

            if (!needToReverse)
            {
                Shared.Write(primitivePlanItem, value, stream);
                return;
            }


            var buffer = new byte[Marshal.SizeOf(value)];
            
            switch (primitivePlanItem.TypeCode)
            {
                case TypeCode.Int32: 
                    WriteInt32BigEndian(buffer, (int)value);
                    break;
                case TypeCode.UInt32: 
                    WriteUInt32BigEndian(buffer, (uint)value);
                    break;
                default: throw new NotImplementedException();
            }
            
            stream.Write(buffer, 0, buffer.Length);
        }

        public void Write(StringPlanItem plan, string value, int length, Stream stream)
        {
            Shared.Write(plan, value, length, stream);
        }
    }
}