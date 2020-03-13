using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabsC_
{
    delegate double Function(double x);
    class Delegate14
    {
        public static double FunctionValue(double x, Function f)
        {
            double res = 0;
            for(int i = -1; i != 3; i += 4)
            {
                res += f(x);
            }
            return res;
        }
    }
}
