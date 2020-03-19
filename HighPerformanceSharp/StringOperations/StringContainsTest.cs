﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StringOperations
{
    public class StringContainsTest : ITestString
    {
        private StringBuilder StringBuilder { get; set; }

        public void Initialize(long size)
        {
            StringBuilder = new StringBuilder();

            Random generator = new Random();

            for (int i = 0; i < size; i++)
            {
                var uppercaseChar = (char)generator.Next(65, 91);
                var lowercaseChar = (char)generator.Next(97, 123);
                var number = generator.Next(0,10);

                var random = generator.NextDouble();
                if (random < 0.33)
                {
                    StringBuilder.Append(uppercaseChar);
                }
                else if (random < 0.66)
                {
                    StringBuilder.Append(lowercaseChar);
                }
                else
                {
                    StringBuilder.Append(number);
                }
            }
        }

        public void Test()
        {
            throw new NotImplementedException();
        }

        public void Validate()
        {
            throw new NotImplementedException();
        }
    }
}