using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BubenkoLG.Sprint6.Task1.V3.Lib;

namespace Tyuiu.BubenkoLG.Sprint6.Task1.V3.Test
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
            double[] wait = { 19.81, 16.79, 13.87, 10.98, 7.94, 3.0, 3.23, -0.45, -3.79, -6.97, -10.0 };
            for (int i = 0; i < res.Length; i++)
            {
                Assert.AreEqual(res[i], wait[i]);
            }
        }
    }
}
