using System;
using System.IO;
using System.Linq;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pw.Serializer;

namespace Pw.Tests.SerializerTests
{
    [TestClass]
    public class GnetSerializerTest
    {
        [TestMethod]
        public void DeSerializeAnnounceZoneId()
        {
            var octetsString =
                "00 00 00 01   00 00 00 01   00    00 00 00 00    00 00 00 00    00 00 00 00    00 00 00 01    00 00 00 00";
            var octets = OctetsStringToBytes(octetsString);
            using var ms = new MemoryStream(octets);
            var serializer = new GnetSerializer();

            var announceZoneId = serializer.DeSerialize<AnnounceZoneId>(ms);

            announceZoneId.Should().NotBeNull();
            announceZoneId.ZoneId.Should().Be(1);
            announceZoneId.Aid.Should().Be(1);
            announceZoneId.BlReset.Should().Be(0);
            announceZoneId.Ip1.Should().Be(0);
            announceZoneId.Ip2.Should().Be(0);
            announceZoneId.Ip3.Should().Be(0);
            announceZoneId.Reserved1.Should().Be(1);
            announceZoneId.Reserved2.Should().Be(0);
        }

        [TestMethod]
        public void DeserializeAndSerializeDeSerializeAnnounceZoneIdShouldEquals()
        {
            var octetsString =
                "00 00 00 01   00 00 00 01   00    00 00 00 00    00 00 00 00    00 00 00 00    00 00 00 01    00 00 00 00";
            var sourceOctets = OctetsStringToBytes(octetsString);
            using var readStream = new MemoryStream(sourceOctets);
            using var writeStream = new MemoryStream();
            var serializer = new GnetSerializer();

            var announceZoneId = serializer.DeSerialize<AnnounceZoneId>(readStream);
            serializer.Serialize(announceZoneId, writeStream);
            var serializedOctets = writeStream.ToArray();

            serializedOctets.Should().BeEquivalentTo(sourceOctets);
        }


        private byte[] OctetsStringToBytes(string octets)
        {
            return octets
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(b => Convert.ToByte(b, 16))
                .ToArray();
        }

        [BigEndian]
        public class AnnounceZoneId
        {
            [Order(0)] public int ZoneId { get; set; }

            [Order(1)] public int Aid { get; set; }

            [Order(2)] public byte BlReset { get; set; }

            [Order(3)] public int Ip1 { get; set; }

            [Order(4)] public int Ip2 { get; set; }

            [Order(5)] public int Ip3 { get; set; }

            [Order(6)] public int Reserved1 { get; set; }

            [Order(7)] public int Reserved2 { get; set; }
        }
    }
}
