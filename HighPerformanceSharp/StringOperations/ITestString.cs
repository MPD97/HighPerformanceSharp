using System;
using System.Collections.Generic;
using System.Text;

namespace StringOperations
{
    partial interface ITestString
    {
        public void Initialize(long size);
        public void Test();
        public void Validate();
    }
}
