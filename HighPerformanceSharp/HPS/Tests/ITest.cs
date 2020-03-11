using System;
using System.Collections.Generic;
using System.Text;

namespace HPS.Tests
{
    public interface ITest
    {
        public abstract void Initialize(Level level);

        public virtual bool TestA()
        {
            return true;
        }
        public virtual bool TestB()
        {
            return true;
        }
        public virtual bool TestC()
        {
            return true;
        }
        public virtual bool TestD()
        {
            return true;
        }
        public virtual bool TestE()
        {
            return true;
        }
    }

    public enum Level
    {
        Easy= 0,
        Medium= 1,
        Hard = 2,
        Extreme= 3
    }
}
