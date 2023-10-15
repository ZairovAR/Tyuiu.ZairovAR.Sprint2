using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ZairovAR.Sprint2.Task4.V16.Lib;

namespace Tyuiu.ZairovAR.Sprint2.Task4.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 12;
            double y = 13;
            double res = ds.Calculate(x, y);
            double wait = 1.073;
            Assert.AreEqual(wait, res);
             
        }

        [TestMethod]
        public void TestMethod2()
        {
            DataService ds = new DataService();
            double x = 15;
            double y = 10;
            double res = ds.Calculate(x, y);
            double wait = 9.996;
            Assert.AreEqual(wait, res);

        }
    }
}
