using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabsC_
{
    //int[] = {1,2,3};
    //pow 4
    //1x^4 + 2x^3 + 3x^2;
    delegate double Op(double key1, double key2);
    class Monomial : ICloneable
    {
        public double Koff { get; set; }
        public int Pow { get; set; }

        public Monomial(double koff, int pow)
        {
            this.Koff = koff;
            this.Pow = pow;
        }

        public override string ToString()
        {
            return Koff + "x^" + Pow;
        }

        public object Clone()
        {
            return new Monomial(Koff, Pow);
        }

        public static Monomial operator *(Monomial a, Monomial b)
        {
            return new Monomial(a.Koff * b.Koff, a.Pow + b.Pow);
        }

    }
    class Polynomial
    {
        public List<Monomial> monomials { get; set; }

        public Polynomial() { }
        public Polynomial(List<Monomial> monomials)
        {
            this.monomials = monomials;
        }

        public void CreateResList()//сортировка по степени по убыв.
        {
            monomials.Sort((s1, s2) =>
            {
                return s2.Pow.CompareTo(s1.Pow);
            });
        }

        public void PrintList()
        {
            foreach (Monomial item in monomials)
            {
                Console.WriteLine(item);
            }
        }

        //Сумма и разность многочленов
        private static Polynomial Operation(Polynomial p1, Polynomial p2, Op op)
        {
            List<Monomial> res = p1.monomials.ConvertAll(m => (Monomial)m.Clone());
            for (var i = 0; i != res.Count; ++i)
            {
                foreach (var j in p2.monomials)
                {
                    if (res[i].Pow == j.Pow)
                    {
                        res[i].Koff = op(res[i].Koff, j.Koff);
                    }
                }
            }
            return new Polynomial(res);
        }
        public static Polynomial OperationsMonomial(Polynomial p1, Polynomial p2, Op op)
        {
            return p1.monomials.Count > p2.monomials.Count ? Operation(p1, p2, op) : Operation(p2, p1, op);
        }

        //Умножение многочленов
        public static Polynomial operator *(Polynomial p1, Polynomial p2)
        {
            List<Monomial> product = new List<Monomial>();
            for (int i = 0; i != p1.monomials.Count; ++i)
            {
                for (int j = 0; j != p2.monomials.Count; ++j)
                {
                    product.Add(p1.monomials[i] * p2.monomials[j]);
                }
            }
            List<Monomial> res = new List<Monomial>(product);
            for (int i = 0; i != res.Count; ++i)
            {
                for (int j = i + 1; j != res.Count; ++j)
                {
                    if (res[i].Pow == res[j].Pow)
                    {
                        res[i].Koff += res[j].Koff;
                        res.RemoveAt(j);
                    }
                }
            }
            return new Polynomial(res);
        }

        //Вычисление значения многочлена для заданного аргумента
        public double ValueCalculation(double arg)
        {
            double res = 0;
            foreach (var i in monomials)
            {
                res += i.Koff * Math.Pow(arg, i.Pow);
            }
            return res;
        }

        //Получение коэффициента, заданного по индексу
        public double GettingCoefficient(int index)
        {
            if (index - 1 >= 0 && index - 1 < monomials.Count)
            {
                return monomials[index - 1].Koff;
            }
            else
            {
                throw new Exception("Polynomial haven't element at a given index!");
            }
        }
    }
}
