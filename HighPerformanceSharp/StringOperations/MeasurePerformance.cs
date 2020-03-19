using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace StringOperations
{
    public class MeasurePerformance
    {
        private Stopwatch Stopwatch { get; set; } = new Stopwatch();

        public void StartTimer()
        {
            Stopwatch.Restart();
        }

        public void StopTimer()
        {
            Stopwatch.Stop();
        }

        public long StartTest(Action action, int testCount)
        {
            List<long> times = new List<long>();
            long result = 0;
            for (int i = 0; i < testCount; i++)
            {
                action.Invoke();
                times.Add(Stopwatch.ElapsedMilliseconds);
            }
            foreach (var time in times)
            {
                result += time;
            }
            return result / testCount;
        }
    }
}
