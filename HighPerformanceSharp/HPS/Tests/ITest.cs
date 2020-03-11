using System;
using System.Collections.Generic;
using System.Text;

namespace HPS.Tests
{
    public interface ITest
    {
        public abstract void Initialize();

        public virtual bool TestA()
        {
            return false;
        }
        public virtual bool TestB()
        {
            return false;
        }
        public virtual bool TestC()
        {
            return false;
        }
    }
}
