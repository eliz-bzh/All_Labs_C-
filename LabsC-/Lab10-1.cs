using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabsC_
{
    [Serializable]
    class Lab10_1
    {
        public double X { get; set; }
        public double B { get; set; }

        public Lab10_1() : this(1, 1) { }
        public Lab10_1(double x, double b)
        {
            this.X = x;
            this.B = b;
        }

        public double Product()
        {
            double prod = X * B;
            double res = 0;
            if (prod < 10 && prod > 1)
            {
                Console.WriteLine("1 < xb < 10");
                for (int i = 1; i != 10; ++i)
                {
                    res += Math.Pow(Math.E, X + Math.Sin(5 * X));
                }
            }
            else
            {
                Console.WriteLine("!(1 < xb < 10)");
                for (int i = 1; i != 10; ++i)
                {
                    res += Math.Pow(Math.Cos(B * Math.Pow(X, 2)), 2);
                }
            }
            return res;
        }
    }
}
