using System;
using System.Buffers.Binary;
using System.Linq;

namespace Pw.Proxy
{
    public static class CompactUIntSerializer
    {
        private const byte DoubleByteHeader = 0x80;
        private const byte SquadByteHeader = 0xC0;

        private const int SingleByteMaxValue = 0x80;
        private const int DoubleByteMaxValue = 0x4000;
        private const int SquadByteMaxValue = 0x20000000;

        private const int DoubleByteFactor = 0x8000;
        private const long SquadByteFactor = 0xC0000000;

        public static byte[] GetBytes(int value)
        {
            if (value < SingleByteMaxValue)
                return new[] { (byte)value };

            if (value < DoubleByteMaxValue)
                return BitConverter.GetBytes((ushort)(value | DoubleByteFactor)).Reverse().ToArray();

            if (value < SquadByteMaxValue)
                return BitConverter.GetBytes((int)(value | SquadByteFactor)).Reverse().ToArray();

            throw new NotImplementedException("Too big");
        }

        public static void WriteBytes(Span<byte> span, int value)
        {
            if (value < SingleByteMaxValue)
            {
                span[0] = (byte)value;
                return;
            }

            if (value < DoubleByteMaxValue)
            {
                var compressed = (ushort)(value | DoubleByteFactor);
                BinaryPrimitives.WriteUInt16BigEndian(span, compressed);
                return;
            }

            if (value < SquadByteMaxValue)
            {
                var compressed = (uint)(value | SquadByteFactor);
                BinaryPrimitives.WriteUInt32BigEndian(span, compressed);
                return;
            }
        }

        public static int GetNumber(ReadOnlySpan<byte> data)
        {
            if (data[0] < DoubleByteHeader)
            {
                return data[0];
            }

            if (data[0] < SquadByteHeader)
            {
                var dirtyValue = BinaryPrimitives.ReadUInt16BigEndian(data);
                return dirtyValue - DoubleByteFactor;
            }

            {
                var dirtyValue = BinaryPrimitives.ReadUInt32BigEndian(data);
                return (int)(dirtyValue - SquadByteFactor);
            }
        }

        public static int GetBytesCount(int value)
        {
            if (value < SingleByteMaxValue)
                return 1;

            if (value < DoubleByteMaxValue)
                return 2;

            if (value < SquadByteMaxValue)
                return 4;

            throw new NotImplementedException("Too big");
        }

        public static int GetBytesCountByHeader(byte firstByte)
        {
            if (firstByte < DoubleByteHeader)
            {
                return 1;
            }

            if (firstByte < SquadByteHeader)
            {
                return 2;
            }

            return 4;
        }
    }
}