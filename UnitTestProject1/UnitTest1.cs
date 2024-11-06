using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TesArea()
        {
            double radius = 6;
            double expected = 113;
            Circle rc = new Circle();
            double actual = rc.Area(radius);
            Assert.AreEqual(expected, actual, "Площадь рассчитывается не правильно.");
        }
    }
    [TestClass]
    public class UnitTest2
    { 
        [TestMethod]
        public void TetCirle()
        {
            double radius = 15;
            double expected = 94;
            Circle rc = new Circle();
            double actual = rc.Cirle(radius);
            Assert.AreEqual(expected, actual, "Окружность рассчитывается не правильно.");
        }
    }
}
