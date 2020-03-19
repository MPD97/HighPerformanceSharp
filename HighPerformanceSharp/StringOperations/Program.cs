using System;
using System.Diagnostics;

namespace StringOperations
{
    class Program
    {
        private static MeasurePerformance Performance { get; set; } = new MeasurePerformance();
        private static ITestString StringTest { get; set; }
        static void Main(string[] args)
        {
            StringTest = new StringContainsTest();

            int testRounds = 5;
            long averageTime = Performance.StartTest(() =>
             {
                 StringTest.Initialize(10000000);
                 Performance.StartTimer();
                 StringTest.Test(StringTest.GetExistingChar());
                 Performance.StopTimer();
                 if (StringTest.Validate() == false) throw new Exception("Validation failed");
             }, testRounds);
            Console.WriteLine($"StringContainsTest. Finding Existing char");
            Console.WriteLine($"Average time of testRounds runs: {averageTime} miliseconds");

        }
    }
}
