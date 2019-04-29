using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Pw.Proxy.Tests
{
    [TestClass]
    public class CompactUIntSerializerTest
    {
        [TestMethod]
        [DataRow(1)]
        [DataRow(2)]
        [DataRow(10)]
        [DataRow(200)]
        [DataRow(3000)]
        [DataRow(40_000)]
        [DataRow(1337)]
        public void SerializedAndDeserializedShouldBeEquals(int value)
        {
            var buffer = CompactUIntSerializer.GetBytes(value);
            var deserialized = CompactUIntSerializer.GetNumber(buffer);

            Assert.AreEqual(value, deserialized);
        }

        [TestMethod]
        [DataRow(1)]
        [DataRow(2)]
        [DataRow(10)]
        [DataRow(200)]
        [DataRow(3000)]
        [DataRow(40_000)]
        [DataRow(1337)]
        public void GetBytesCount(int value)
        {
            var bufferLength = CompactUIntSerializer.GetBytes(value).Length;
            var bytesCount = CompactUIntSerializer.GetBytesCount(value);

            Assert.AreEqual(bufferLength, bytesCount);
        }

        [TestMethod]
        [DataRow(1)]
        [DataRow(2)]
        [DataRow(10)]
        [DataRow(200)]
        [DataRow(3000)]
        [DataRow(40_000)]
        [DataRow(1337)]
        public void GetBytesCountByHeader(int value)
        {
            var buffer = CompactUIntSerializer.GetBytes(value);
            var bufferLength = buffer.Length;
            var bytesCount = CompactUIntSerializer.GetBytesCountByHeader(buffer[0]);

            Assert.AreEqual(bufferLength, bytesCount);
        }

        [TestMethod]
        [DataRow(1)]
        [DataRow(2)]
        [DataRow(10)]
        [DataRow(200)]
        [DataRow(3000)]
        [DataRow(40_000)]
        [DataRow(1337)]
        public void WriteSpanShouldCreateBufferSameWithGetBytes(int value)
        {
            var getBytesBuffer = CompactUIntSerializer.GetBytes(value);
            var writeBytesBuffer = new byte[getBytesBuffer.Length];
            CompactUIntSerializer.WriteBytes(writeBytesBuffer, value);

            CollectionAssert.AreEqual(getBytesBuffer, writeBytesBuffer);
        }
    }
}
