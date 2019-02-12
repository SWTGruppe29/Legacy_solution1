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
        public void TurnOn()
        {

        }

        public void TurnOff()
        {

        }

        public bool RunSelfTest()
        {
            return true;
        }
    }
}