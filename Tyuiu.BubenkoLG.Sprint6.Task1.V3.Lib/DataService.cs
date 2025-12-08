using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;
using System.Runtime.InteropServices;

namespace Tyuiu.BubenkoLG.Sprint6.Task1.V3.Lib
{
    public class DataService : ISprint6Task1V3
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] result = new double[11];
            int i = 0;
            while (startValue != stopValue+1)
            {
                if (2*startValue-0.5 == 0)
                {
                    result[i] = 0;
                }
                else
                {
                    result[i] = Math.Round(5 - 3*startValue + ((1+Math.Sin(startValue))/(2*startValue-0.5)),2);
                }
                i++;
                startValue++;
            }
            return result;
        }
    }
}