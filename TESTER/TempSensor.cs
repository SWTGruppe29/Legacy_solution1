﻿using System;
using TESTER;

namespace ECS.Legacy
{
    internal class TempSensor : ITempSensor
    {
        private Random gen = new Random();

        public int GetTemp()
        {
            return gen.Next(-5, 45);
        }

        public bool RunSelfTest()
        {
            return true;
        }
    }

    public class FakeTempSensor : ITempSensor
    {
        public int GetTempCalled;
        public int SetTemp;
        public int GetTemp()
        {
            GetTempCalled++;
            return SetTemp;
        }

        public bool RunSelfTest()
        {
            return true;
        }
    }
}