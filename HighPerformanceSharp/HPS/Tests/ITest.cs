﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HPS.Tests
{
    public interface ITest
    {
        public abstract void Initialize(Level level);

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

    public enum Level
    {
        Easy= 0,
        Medium= 1,
        Hard = 2,
        Extreme= 3
    }
}
