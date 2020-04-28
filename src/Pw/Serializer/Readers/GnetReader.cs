using System;
using System.IO;
using Pw.Serializer.Plans;
using static System.Buffers.Binary.BinaryPrimitives;

// ReSharper disable HeapView.BoxingAllocation

namespace Pw.Serializer.Readers
{
    public class GnetReader : IReader
    {
        public object Read(PrimitivePlanItem primitivePlanItem, Stream stream)
        {
            var needToReverse = primitivePlanItem.BigEndian
                                && primitivePlanItem.TypeCode != TypeCode.Byte
                                && primitivePlanItem.TypeCode != TypeCode.Single;

            if (!needToReverse)
                return Shared.Read(primitivePlanItem, stream);

            switch (primitivePlanItem.TypeCode)
            {
                case TypeCode.Int32: return ReadInt32BigEndian(ReadBytes(4));
                case TypeCode.UInt32: return ReadUInt32BigEndian(ReadBytes(4));
                default: throw new NotImplementedException();
            }

            byte[] ReadBytes(int chunkSize)
            {
                var buffer = new byte[chunkSize];
                stream.Read(buffer, 0, chunkSize);
                return buffer;
            }
        }

        public object Read(StringPlanItem plan, int length, Stream stream)
        {
            return Shared.Read(plan, length, stream);
        }
    }
}
