﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace LegacyExerciseUnitTester
{
    [TestFixture]

    public class ECSTestClass
    {
        [Test]
        public void Test1()
        {

            Assert.That(2, Is.EqualTo(2));
        }

    }
}
