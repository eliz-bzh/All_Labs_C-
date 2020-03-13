using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabsC_
{
    class Сset<T>
    {
        public List<T> Set { get; set; }

        public Сset() { }

        public Сset(List<T> set)
        {
            Set = set;
        }

        ~Сset()
        {
            Set.Clear();
        }

        public static Сset<T> operator +(Сset<T> cset, T item)
        {
            cset.Set.Add(item);
            return new Сset<T>(cset.Set);
        }

        public static Сset<T> operator *(Сset<T> cset, Сset<T> cset1)
        {
            List<T> res = new List<T>();
            for (int i = 0; i != cset1.Set.Count; ++i)
            {
                if (cset.Set.Contains(cset1.Set[i]))
                {
                    res.Add(cset1.Set[i]);
                }
            }
            return new Сset<T>(res);
        }

        public static bool operator !=(Сset<T> cset, Сset<T> cset1)
        {
            return !cset.Set.SequenceEqual(cset1.Set);
        }

        public static bool operator ==(Сset<T> cset, Сset<T> cset1)
        {
            return cset.Set.SequenceEqual(cset1.Set);
        }

        public void Print()
        {
            foreach (var item in Set)
            {
                Console.WriteLine(item);
            }
        }
    }
}
