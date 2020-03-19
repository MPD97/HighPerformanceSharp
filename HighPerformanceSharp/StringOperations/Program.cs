using System;
using System.Diagnostics;

namespace StringOperations
{
    class Program
    {

        private static MeasurePerformance Performance { get; set; } = new MeasurePerformance();
        private static StringContainsTest StringTest { get; set; }
        static void Main(string[] args)
        {
            const int Size = 10000000;
            StringTest = new StringContainsTest();

            int testRounds = 5;
            long averageTime = Performance.StartTest(() =>
             {
                 StringTest.Initialize(Size);
                 Performance.StartTimer();
                 StringTest.Test(StringTest.GetExistingChar());
                 Performance.StopTimer();
                 if (StringTest.Validate() == false) throw new Exception("Validation failed");
             }, testRounds);
            Console.WriteLine($"StringContainsTest. Finding Existing char");
            Console.WriteLine($"Average time of testRounds runs: {averageTime} miliseconds");

            averageTime = Performance.StartTest(() =>
               {
                   StringTest.Initialize(Size);
                   Performance.StartTimer();
                   StringTest.Test(StringTest.GetNotExistingChar());
                   Performance.StopTimer();
                   if (StringTest.Validate() == false) throw new Exception("Validation failed");
               }, testRounds);
            Console.WriteLine($"StringContainsTest. Finding NOT Existing char");
            Console.WriteLine($"Average time of testRounds runs: {averageTime} miliseconds");

            averageTime = Performance.StartTest(() =>
            {
                StringTest.Initialize(Size);
                Performance.StartTimer();
                StringTest.Test(StringTest.GetExistingString());
                Performance.StopTimer();
                if (StringTest.Validate() == false) throw new Exception("Validation failed");
            }, testRounds);
            Console.WriteLine($"StringContainsTest. Finding Existing string");
            Console.WriteLine($"Average time of testRounds runs: {averageTime} miliseconds");

            averageTime = Performance.StartTest(() =>
            {
                StringTest.Initialize(Size);
                Performance.StartTimer();
                StringTest.Test(StringTest.GetNotExistingString());
                Performance.StopTimer();
                if (StringTest.Validate() == false) throw new Exception("Validation failed");
            }, testRounds);
            Console.WriteLine($"StringContainsTest. Finding NOT Existing string");
            Console.WriteLine($"Average time of testRounds runs: {averageTime} miliseconds");
        }
    }
}
