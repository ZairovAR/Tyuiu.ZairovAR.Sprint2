using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZairovAR.Sprint2.Task0.V23.Lib;

namespace Tyuiu.ZairovAR.Sprint2.Task0.V23.Test
{
    [TestClass]
    public class DataServiseTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 105;
            int y = 795;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);
            bool[] wait = new bool[6] { true, false, true, true, false, true };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
