using System;
using System.Collections.Generic;
using System.Text;

namespace HPS.Tests
{
    class ArrayTest : ITest
    {
        private int[] array;

        public ArrayTest()
        {
            Console.WriteLine($"Array reverse test");
        }

        private void FillData(int size)
        {
            Console.WriteLine($"Initialize table with size of {size}");

            array = new int[size];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (i * 2);
            }
        }
        public void Initialize(Level level)
        {
            switch (level)
            {
                case Level.Easy:
                    {
                        FillData(500);
                        break;
                    }
                case Level.Medium:
                    {
                        FillData(10000);
                        break;
                    }
                case Level.Hard:
                    {
                        FillData(100000);
                        break;
                    }
                case Level.Extreme:
                    {
                        FillData(1000000);
                        break;
                    }
            }
        }

        public bool TestA()
        {
            return false;
        }
        public bool TestB()
        {
            return false;
        }
        public bool TestC()
        {
            return false;
        }
    }
}
