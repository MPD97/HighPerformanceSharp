using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using HPS.Tests;

namespace HPS
{
    class Program
    {
        static void Main(string[] args)
        {

            var line = "";
            while (true)
            {
                PerformTest(new ArrayTest(), Level.Extreme, 20);
                Console.ReadLine();
            }
        }

        static void PerformTest(ITest testClass, Level level, int testCount)
        {
            List<long> timeResultsA = new List<long>();
            List<long> timeResultsB = new List<long>();
            List<long> timeResultsC = new List<long>();

            for (int i = 0; i < testCount; i++)
            {
                testClass.Initialize(level);

                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                if (testClass.TestA() == false)
                {
                    throw  new Exception("TestA returned false");
                }

                stopwatch.Stop();
                timeResultsA.Add(stopwatch.ElapsedMilliseconds);
            }

            Console.WriteLine($"TestA: {CountResults(timeResultsA)}ms");
            


            for (int i = 0; i < testCount; i++)
            {
                testClass.Initialize(level);

                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                if (testClass.TestB() == false)
                {
                    throw new Exception("TestB returned false");
                }

                stopwatch.Stop();
                timeResultsB.Add(stopwatch.ElapsedMilliseconds);
            }
            Console.WriteLine($"TestB: {CountResults(timeResultsB)}ms");

            for (int i = 0; i < testCount; i++)
            {
                testClass.Initialize(level);

                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                if (testClass.TestC() == false)
                {
                    throw new Exception("TestC returned false");
                }

                stopwatch.Stop();
                timeResultsC.Add(stopwatch.ElapsedMilliseconds);
            }
            Console.WriteLine($"TestC: {CountResults(timeResultsC)}ms");

        }

        private static long CountResults(List<long> list)
        {
            long result = 0;
            foreach (var element in list)
            {
                result += element;
            }

            return result / list.Count;
        }
    }
}
