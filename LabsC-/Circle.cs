using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabsC_
{
    class Circle
    {
        private double r;

        public double R { get => r;
            set
            {
                if(value <= 0)
                {
                    throw new Exception("Radius can't be negative or equal 0");
                }
                r = value;
            }
        }

        public Circle() : this(1) { }

        public Circle(double r)
        {
            this.R = r;
        }

        public double Circumference { get => 2 * Math.PI * R; }
        public double AreaOfTheCircle { get => Math.PI * Math.Pow(R, 2); }
    }
}
