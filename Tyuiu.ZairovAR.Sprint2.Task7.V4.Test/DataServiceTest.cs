﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ZairovAR.Sprint2.Task7.V4.Lib;
namespace Tyuiu.ZairovAR.Sprint2.Task7.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 1;

            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;

            Assert.AreEqual(wait, res);
        }
    }
}
