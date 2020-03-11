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
            int[] temp = new int[array.Length];
            int index = 0;
            foreach (var element in array)
            {
                temp[temp.Length - 1 - index++] = element;
            }

            return true;
        }
        public bool TestB()
        {
            int[] temp = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                temp[i] = array[array.Length - 1 - i];
            }

            return true;
        }
        public bool TestC()
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                int temp = array[i];
                array[i] = array[array.Length - i - 1];
                array[array.Length - i - 1] = temp;
            }

            return true;
        }
    }
}
