using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BubenkoLG.Sprint6.Task2.V8.Lib;

namespace Tyuiu.BubenkoLG.Sprint6.Task2.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            double[] res = ds.GetMassFunction(startValue, stopValue);
            double[] wait = { -11.22, -8.65, -4.76, -6.47, -2.98, 1.0, 1.82, 3.55, 6.99, 7.74, 9.03 };
            for (int i = 0; i < res.Length; i++)
            {
                Assert.AreEqual(res[i], wait[i]);
            }
        }
    }
}