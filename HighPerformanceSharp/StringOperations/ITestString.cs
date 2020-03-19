using System;
using System.Collections.Generic;
using System.Text;

namespace StringOperations
{
    partial interface ITestString
    {
        public void Initialize(long size);

        public bool Test(string text);
        public bool Test(char text);

        public bool Validate();
    }
}
