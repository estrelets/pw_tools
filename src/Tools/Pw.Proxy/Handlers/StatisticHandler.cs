using System;
using System.Diagnostics;
using System.Threading;
using Humanizer;
using Pw.Proxy.Server;

namespace Pw.Proxy.Handlers
{
    public class StatisticHandler : IPacketHandler
    {
        private static int _counter = 0;
        private static int _bytesHandled = 0;
        private static long _elapsed = 0;

        private static int _totalCounter = 0;
        private static int _totalBytesHandled = 0;

        private static int _avgCount = 0;

        static StatisticHandler()
        {
            PrintStatistic();
        }

        public void Handle(Packet packet, Bridge bridge)
        {
            Interlocked.Increment(ref _counter);
            Interlocked.Add(ref _bytesHandled, packet.Data.Length);
            Interlocked.Add(ref _elapsed, packet.Elapsed);
        }

        private static void PrintStatistic()
        {
            new Thread(() =>
            {
                while (true)
                {
                    var count = _counter == 0 ? 1 : _counter;
                    var bytesHandled = _bytesHandled;
                    var elapsed = _elapsed;

                    Interlocked.Exchange(ref _counter, 0);
                    Interlocked.Exchange(ref _bytesHandled, 0);
                    Interlocked.Exchange(ref _elapsed, 0);

                    _totalCounter += count;
                    _totalBytesHandled += bytesHandled;
                    _avgCount++;

                    var packetsTotal = _totalCounter;
                    var averagePackets = (double)_totalCounter / _avgCount;
                    var bytesTotal = _totalBytesHandled.Bytes().ToString("0.00");
                    var bytes = bytesHandled.Bytes().ToString("0.00");

                    var threadsCount = Process.GetCurrentProcess().Threads.Count;
                    var memory = GC.GetTotalMemory(true).Bytes().ToString("0.00");

                    Console.WriteLine($"Packets: {count}/{packetsTotal} avg={averagePackets:F1}" +
                                      $" Network: {bytes}/{bytesTotal}" +
                                      $" Elapsed: {(double)elapsed / count:F1}" +
                                      $" Diagnostic: threads={threadsCount} memory={memory}");

                    Thread.Sleep(1000);
                }
            }).Start();
        }
    }
}