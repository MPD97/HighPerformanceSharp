using System;
using System.Collections.Generic;
using System.Text;

namespace StringOperations
{
    partial interface ITestString
    {
        public char GetExistingChar();
        public char GetNotExistingChar();
        public string GetExistingString();
        public string GetNotExistingString();

        public void Initialize(long size);

        public bool Test(string text);
        public bool Test(char text);

        public bool Validate();
    }
}
