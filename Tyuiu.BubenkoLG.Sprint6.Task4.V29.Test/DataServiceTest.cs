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
            double[] wait = { 25.6, 23.95, 20.95, 13.53, 3.84, -6.0, -2.57, -8.26, -12.44, -17.56, -24.01 };
            for (int i = 0; i < res.Length; i++)
            {
                Assert.AreEqual(res[i], wait[i]);
            }
        }
    }
}