using System;
using System.IO.Pipelines;
using System.Threading.Tasks;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pw.Proxy.Server;

namespace Pw.Proxy.Tests
{
    [TestClass]
    public class PacketReaderTests
    {
        [TestMethod]
        public async Task ShouldParsePacket()
        {
            var pipe = new Pipe();
            var reader = new PacketReader();
            var opCode = 1;
            var payload = new byte[] { 1, 2 };

            await Write(CompactUIntSerializer.GetBytes(opCode));
            await Write(CompactUIntSerializer.GetBytes(payload.Length));
            await Write(payload);

            var packet = await reader.Read(pipe.Reader, default);

            packet.Should().NotBeNull();
            packet.OpCode.Should().Be(1);
            packet.Data.Should().BeEquivalentTo(payload);

            async Task Write(byte[] data)
            {
                var writer = pipe.Writer;
                await writer.WriteAsync(new ReadOnlyMemory<byte>(data));
            }
        }
    }
}
