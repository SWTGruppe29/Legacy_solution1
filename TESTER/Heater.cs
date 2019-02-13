using System.Data;
using TESTER;

namespace ECS.Legacy
{
    public class Heater : IHeater
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
    }

    public class FakeHeater : IHeater
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
    }
}