﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ZairovAR.Sprint2.Task6.V4.Lib;

namespace Tyuiu.ZairovAR.Sprint2.Task6.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int value = 3;
            string res = ds.FindCardSuit(value);
            string wait = "бубны";
            Assert.AreEqual(wait, res);
        }
    }
}
