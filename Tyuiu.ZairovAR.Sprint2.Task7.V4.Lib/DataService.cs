using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;


namespace Tyuiu.ZairovAR.Sprint2.Task7.V4.Lib
{
    public class DataService : ISprint2Task7V4
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            double equationResult = (Math.Sqrt(1 - Math.Pow(x, 2)));
            if (y <= equationResult && (x > 0.3) && (y > 0.3));
            {
                return true;
            }
            
        }
    }
}
