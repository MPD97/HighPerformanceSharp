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
            ITest[] availableTests = new ITest[]
            {
                new ArrayTest(),
            };

            var line = "";
            while (true)
            {
                PrintAvailableTests(availableTests);

                line = Console.ReadLine();
                int number = -1;
                int.TryParse(line, out number);

                Console.WriteLine("Select level:");
                Console.WriteLine(" (0) - Easy");
                Console.WriteLine(" (1) - Medium");
                Console.WriteLine(" (2) - Hard");
                Console.WriteLine(" (3) - Extreme");
                line = Console.ReadLine();

                int levelNumber;
                int.TryParse(line, out levelNumber);


                if (number >= 0 && number <= availableTests.Length - 1 && levelNumber >= 0 && levelNumber <= 3)
                {
                    PerformTest(availableTests[number], (Level) levelNumber, 20);
                }
                else
                {
                    Console.WriteLine("Wrong input");
                }
            }
        }

        private static void PrintAvailableTests(ITest[] availableTests)
        {
            Console.WriteLine("Available Tests: ");
            for (int i = 0; i < availableTests.Length; i++)
            {
                Console.WriteLine($" ({i}) - {availableTests[i].GetType().Name}");
            }
        }

        static void PerformTest(ITest testClass, Level level, int testCount)
        {
            List<long> timeResultsA = new List<long>();
            List<long> timeResultsB = new List<long>();
            List<long> timeResultsC = new List<long>();
            List<long> timeResultsD = new List<long>();
            List<long> timeResultsE = new List<long>();

            Console.WriteLine($"Selected level {level.ToString()}");
            for (int i = 0; i < testCount; i++)
            {
                testClass.Initialize(level);

                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                if (testClass.TestA() == false)
                {
                    throw new Exception("TestA returned false");
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


            for (int i = 0; i < testCount; i++)
            {
                testClass.Initialize(level);

                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                if (testClass.TestD() == false)
                {
                    throw new Exception("TestD returned false");
                }

                stopwatch.Stop();
                timeResultsD.Add(stopwatch.ElapsedMilliseconds);
            }

            Console.WriteLine($"TestD: {CountResults(timeResultsD)}ms");
            for (int i = 0; i < testCount; i++)
            {
                testClass.Initialize(level);

                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                if (testClass.TestE() == false)
                {
                    throw new Exception("TestE returned false");
                }

                stopwatch.Stop();
                timeResultsE.Add(stopwatch.ElapsedMilliseconds);
            }
            Console.WriteLine($"TestE: {CountResults(timeResultsE)}ms");

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
