using System;
using System.IO.Pipelines;
using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pw.Proxy.Server;

namespace Pw.Proxy.Tests
{
    [TestClass]
    public class PacketReceiverTest
    {
        private TestDataProducer _producer;
        private PacketReader _reader;
        private PacketReceiver _receiver;

        [TestInitialize]
        public void Init()
        {
            _reader = new PacketReader();
            _producer = new TestDataProducer();
            _receiver = new PacketReceiver(_producer, _reader);
        }

        [TestMethod]
        public async Task ShouldReadPacket()
        {
            var opCode = 1;
            var payload = new byte[] {1, 2};
            var cts = new CancellationTokenSource();

            _receiver.StartReceive(cts.Token);
            await _producer.Write(CompactUIntSerializer.GetBytes(opCode));
            await _producer.Write(CompactUIntSerializer.GetBytes(payload.Length));
            await _producer.Write(payload);

            await foreach (var packet in _receiver.ReadPackets(cts.Token))
            {
                packet.Should().NotBeNull();
                packet.OpCode.Should().Be(1);
                packet.Data.Should().BeEquivalentTo(payload);

                cts.Cancel();
            }
        }

        [TestMethod]
        public async Task BadSocketConnection()
        {
            var opCode = 1;
            var payload = new byte[] {1, 2};
            var cts = new CancellationTokenSource();

            _receiver.StartReceive(cts.Token);
#pragma warning disable 4014
            Task.Run(() => BadConnectionSimulation());
#pragma warning restore 4014

            await foreach (var packet in _receiver.ReadPackets(cts.Token))
            {
                packet.Should().NotBeNull();
                packet.OpCode.Should().Be(1);
                packet.Data.Should().BeEquivalentTo(payload);

                cts.Cancel();
            }

            async Task BadConnectionSimulation()
            {
                await _producer.Write(CompactUIntSerializer.GetBytes(opCode));
                await Task.Delay(100);
                await _producer.Write(CompactUIntSerializer.GetBytes(payload.Length));
                await Task.Delay(100);
                await _producer.Write(payload);
            }
        }

        private class TestDataProducer : IRawDataProducer
        {
            private PipeWriter _writer;

            public Task Produce(PipeWriter writer, CancellationToken cancellationToken)
            {
                _writer = writer;
                return Task.FromResult(0);
            }

            public async Task Write(byte[] buffer)
            {
                await _writer.WriteAsync(new ReadOnlyMemory<byte>(buffer));
            }
        }
    }
}
