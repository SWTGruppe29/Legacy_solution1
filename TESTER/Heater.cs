using System;
using System.Data;
using System.Diagnostics;
using TESTER;

namespace ECS.Legacy
{
    public class Heater : ISwitch
    {
        public void TurnOn()
        {
            System.Console.WriteLine("Heater is on");
        }

        public void TurnOff()
        {
            System.Console.WriteLine("Heater is off");
        }

        public bool RunSelfTest()
        {
            return true;
        }

        public bool getIsOn()
        {
            return true;
        }
    }

    public class FakeHeater : ISwitch
    {
        public bool IsOn;
        public void TurnOn()
        {
            IsOn = true;
        }

        public void TurnOff()
        {
            IsOn = false;
        }

        public bool RunSelfTest()
        {
            return true;
        }

        public bool getIsOn()
        {
            return IsOn;
        }
    }

    public class FakeWindow : ISwitch
    {
        private bool isOpen;

        public void TurnOn()
        {
            isOpen = true;
        }

        public void TurnOff()
        {
            isOpen = false;
        }

        public bool RunSelfTest()
        {
            return true;
        }

        public bool getIsOn()
        {
            return isOpen;
        }

        public bool IsOpen
        {
            get { return isOpen; }
        }
    }

    public class Window : ISwitch
    {
        public void TurnOn()
        {
            Console.WriteLine("Opening the window");
        }

        public void TurnOff()
        {
            Console.WriteLine("Closing the window");
        }
        
        public bool RunSelfTest()
        {
            return true;
        }

        public bool getIsOn()
        {
            return true;
        }
    }
}