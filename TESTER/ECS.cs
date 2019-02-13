using TESTER;

namespace ECS.Legacy
{
    public class ECS
    {
        private int _heatingThreshold;
        private int _upperThreshold;
        private readonly ITempSensor _tempSensor;
        private readonly ISwitch _heater;
        private readonly ISwitch _window;

        public ECS(int thr, ISwitch heater, ISwitch window, ITempSensor tempSensor)
        {
            SetThreshold(thr);
            _window = window;
            _tempSensor = tempSensor;
            _heater = heater;
        }

        public void Regulate()
        {
            var t = _tempSensor.GetTemp();
            if (t < _heatingThreshold)
            {
                _window.TurnOff();
                _heater.TurnOn();
            }
            else if (t >= _heatingThreshold && t <= _upperThreshold)
            {
                _window.TurnOff();
                _heater.TurnOff();
            }
            else
            {
                _window.TurnOn();
                _heater.TurnOff();
            }
        }

        public void SetThreshold(int thr)
        {
            _heatingThreshold = thr;
        }

        public void SetUpperThreshold(int thr)
        {
            _upperThreshold = thr;
        }
        public int GetThreshold()
        {
            return _heatingThreshold;
        }

        public int GetUpperThreshold()
        {
            return _upperThreshold;
        }
        public int GetCurTemp()
        {
            return _tempSensor.GetTemp();
        }

        public bool RunSelfTest()
        {
            return _tempSensor.RunSelfTest() && _heater.RunSelfTest();
        }
    }
}
