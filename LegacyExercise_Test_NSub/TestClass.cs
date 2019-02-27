using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECS.Legacy;
using NSubstitute;
using TESTER;

namespace LegacyExercise_Test_NSub
{
    [TestFixture]
    public class TestClass
    {

        [Test]
        public void TestECSThresh()
        {
            var test1 = Substitute.For<ITempSensor>();
        }
    }
}
