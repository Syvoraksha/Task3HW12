using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3HW12
{
    public class Calculations
    {
        public string ReturnResult(double a, double b, double c, double d, double e, double f) 
        {
            double result = a + b * c / Math.Pow((d - e), f);
            return result.ToString();
        }
    }
}
