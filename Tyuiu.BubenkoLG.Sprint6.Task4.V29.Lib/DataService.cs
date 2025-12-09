using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;
using System.Runtime.InteropServices;

namespace Tyuiu.BubenkoLG.Sprint6.Task4.V29.Lib
{
    public class DataService : ISprint6Task4V29
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] result = new double[11];
            int i = 0;
            while (startValue != stopValue + 1)
            {
                if (Math.Cos(startValue)-2*startValue == 0)
                {
                    result[i] = 0;
                }
                else
                {
                    result[i] = Math.Round(((2*startValue-3)/(Math.Cos(startValue))-2*startValue)+5*startValue-6, 2);
                }
                i++;
                startValue++;
            }
            return result;
        }
    }
}