using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace StringOperations
{
    public class MeasurePerformance
    {
        private Stopwatch Stopwatch { get; set; } = new Stopwatch();

        public void Start()
        {
            Stopwatch.Restart();
        }

        public Stopwatch GetResult()
        {
            Stopwatch.Stop();
            return Stopwatch;
        }
    }
}
