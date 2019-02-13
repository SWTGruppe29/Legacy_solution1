using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECS.Legacy;
using NUnit.Framework;
using TESTER;

namespace LegacyExerciseUnitTester
{
    [TestFixture]

    public class ECSTestClass
    {
        [Test]
        public void TestECSThresholdGet()
        {
            var uut = new ECS.Legacy.ECS(20, new FakeHeater(), new FakeWindow(),  new FakeTempSensor());
            Assert.That(uut.GetThreshold(), Is.EqualTo(20));
        }

        [Test]
        public void TestFakeHeaterIsOff()
        {
            FakeHeater fuut = new FakeHeater();
            FakeTempSensor Fuut2 = new FakeTempSensor();
            Fuut2.SetTemp = 10;
            var uut = new ECS.Legacy.ECS(5, fuut, new FakeWindow(),  Fuut2);
            uut.Regulate();
            Assert.That(fuut.IsOn, Is.EqualTo(false));
        }


        [Test]
        public void TestFakeHeaterIsOn()
        {
            FakeHeater fuut = new FakeHeater();
            var uut = new ECS.Legacy.ECS(20, fuut, new FakeWindow(),  new FakeTempSensor());
            uut.Regulate();
            Assert.That(fuut.IsOn, Is.EqualTo(true));
        }


        [Test]
        public void TestTempSensor()
        {
            FakeTempSensor Fuut = new FakeTempSensor();
            Fuut.SetTemp = 10;
            var uut = new ECS.Legacy.ECS(20, new FakeHeater(), new FakeWindow(),  Fuut);
            Assert.That(Fuut.GetTemp(), Is.EqualTo(10));
        }

        [Test]
        public void TestTempSensorTempCalled()
        {
            FakeTempSensor Fuut = new FakeTempSensor();
            Fuut.GetTemp();
            Fuut.GetTemp();
            Assert.That(Fuut.GetTempCalled, Is.EqualTo(2));
        }

        [Test]
        public void TestFakeWindowIsOpened()
        {
            FakeWindow Fuut = new FakeWindow();
            FakeTempSensor Fuut2 = new FakeTempSensor();
            Fuut2.SetTemp = 35;
            var uut = new ECS.Legacy.ECS(20,new FakeHeater(), Fuut, Fuut2);
            uut.SetUpperThreshold(30);
            uut.Regulate();
            Assert.That(Fuut.getIsOn, Is.EqualTo(true));

        }
        public void TestFakeWindowIsClosed()
        {
            FakeWindow Fuut = new FakeWindow();
            FakeTempSensor Fuut2 = new FakeTempSensor();
            Fuut2.SetTemp = 15;
            var uut = new ECS.Legacy.ECS(20, new FakeHeater(), Fuut, new FakeTempSensor());
            uut.SetUpperThreshold(30);
            uut.Regulate();
            Assert.That(Fuut.getIsOn, Is.EqualTo(false));

        }
    }
}
