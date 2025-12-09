using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BubenkoLG.Sprint6.Task4.V29.Lib;

namespace Tyuiu.BubenkoLG.Sprint6.Task4.V29.Test
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
            double[] wait = { -32.26, -27.5, -22.8, -17.95, -12.97, -9.0, -0.31, 3.77, 8.57, 13.42, 18.28 };
            for (int i = 0; i < res.Length; i++)
            {
                Assert.AreEqual(res[i], wait[i]);
            }
        }
    }
}