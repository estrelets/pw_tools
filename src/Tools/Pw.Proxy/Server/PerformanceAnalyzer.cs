using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using Humanizer;

namespace Pw.Proxy.Server
{
    public class PerformanceAnalyzer
    {
        private static readonly TimeSpan StatisticPeriod = TimeSpan.FromSeconds(1);

        private readonly Timer _collectorTimer;
        private readonly StatisticCollector _collector;
        private readonly ConditionalWeakTable<Packet, AnalyzeItem> _packets = new ConditionalWeakTable<Packet, AnalyzeItem>();

        public IReadOnlyDictionary<DateTime, Statistic> Statistics => _collector.Statistics;

        public PerformanceAnalyzer()
        {
            _collector = new StatisticCollector();
            _collectorTimer = new Timer(_ => PrintStat(), null, TimeSpan.Zero, StatisticPeriod);

            void PrintStat()
            {
                var stat = _collector.Collect();
                if (stat != null)
                    Console.WriteLine(stat);
            }
        }


        public void StartRead(Packet p)
        {
            var item = new AnalyzeItem();
            item.StartRead();
            _packets.Add(p, item);
        }

        public void FinishRead(Packet p)
        {
            if (_packets.TryGetValue(p, out var item))
            {
                item.StopRead();
            }
        }

        public void StartHandle(Packet p)
        {
            if (_packets.TryGetValue(p, out var item))
            {
                item.StartHandle();
            }
        }

        public void FinishHandle(Packet p)
        {
            if (_packets.TryGetValue(p, out var item))
            {
                item.StopHandle();
                _collector.Handle(p, item);
            }
        }

        public class Statistic
        {
            public int Count { get; set; }
            public int TotalCount { get; set; }

            public int HandledBytes { get; set; }
            public int TotalHandledBytes { get; set; }

            public double AverageReadTime { get; set; }
            public double AverageHandlingTime { get; set; }

            public int Threads { get; set; }
            public long Memory { get; set; }

            public override string ToString()
            {
                var totalHandledBytes = TotalHandledBytes.Bytes().ToString("0.00");
                var currentHandledBytes = HandledBytes.Bytes().ToString("0.00");
                var memory = Memory.Bytes().ToString("0.00");

                return $"Packets: {Count}/{TotalCount} " +
                       $"Network: {currentHandledBytes}/{totalHandledBytes} " +
                       $"Reading: {AverageReadTime:F1} Handling: {AverageHandlingTime:F1} " +
                       $"Diagnostic: threads={Threads} memory={memory}";
            }
        }

        private class StatisticCollector
        {
            public Dictionary<DateTime, Statistic> Statistics { get; } = new Dictionary<DateTime, Statistic>();

            private int _counter = 0;
            private int _bytesHandled = 0;

            private long _readTime = 0;
            private long _handlingTime = 0;

            private int _totalCounter = 0;
            private int _totalBytesHandled = 0;

            public void Handle(Packet packet, AnalyzeItem analyzeItem)
            {
                Interlocked.Increment(ref _counter);

                Interlocked.Add(ref _bytesHandled, packet.Data.Length);
                Interlocked.Add(ref _handlingTime, analyzeItem.Handling);
                Interlocked.Add(ref _readTime, analyzeItem.Reading);
            }

            public Statistic Collect()
            {
                if (_counter == 0)
                {
                    return null;
                }

                var (count, bytesHandled, readTime, handlingTime) = ResetPreviousIteration();
                var (totalPacketsCount, totalBytesHandled) = UpdateTotals();

                var statistic = new Statistic()
                {
                    Count = count,
                    TotalCount = totalPacketsCount,
                    HandledBytes = bytesHandled,
                    TotalHandledBytes = _totalBytesHandled,
                    AverageReadTime = (double) readTime / count,
                    AverageHandlingTime = (double) readTime / handlingTime,
                    Memory = GC.GetTotalMemory(true),
                    Threads = Process.GetCurrentProcess().Threads.Count
                };

                Statistics.Add(DateTime.Now, statistic);
                return statistic;

                (int count, int bytesHandled, long readTime, long handlingTime) ResetPreviousIteration()
                {
                    var values = (_counter, _bytesHandled, _readTime, _handlingTime);
                    Interlocked.Exchange(ref _counter, 0);
                    Interlocked.Exchange(ref _bytesHandled, 0);
                    Interlocked.Exchange(ref _readTime, 0);
                    Interlocked.Exchange(ref _handlingTime, 0);
                    return values;
                }

                (int totalPacketsCount, int totalBytesHandled) UpdateTotals()
                {
                    var values = (_totalCounter, _totalBytesHandled);
                    _totalCounter += count;
                    _totalBytesHandled += bytesHandled;
                    return values;
                }
            }
        }

        private class AnalyzeItem
        {
            private Stopwatch _stopwatch;

            public long Reading { get; set; }
            public long Handling { get; set; }

            public void StartRead() => _stopwatch = Stopwatch.StartNew();
            public void StartHandle() => _stopwatch = Stopwatch.StartNew();

            public void StopRead() => Reading = _stopwatch.ElapsedMilliseconds;
            public void StopHandle() => Handling = _stopwatch.ElapsedMilliseconds;
        }
    }
}
