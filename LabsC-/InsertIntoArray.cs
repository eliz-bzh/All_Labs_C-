using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabsC_
{
    class InsertIntoArray
    {
        public List<int> List { get; set; }

        private int n;
        public int N
        {
            get => n;
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Size can't be negative or equal 0");
                }
                n = value;
            }
        }

        private int k;
        public int K { get => k;
            set
            {
                if(1 <= value && value <= N)
                {
                    k = value;
                }
                else
                {
                    throw new Exception("Value doesn't fit");
                }
            }
        }

        private int m;
        public int M { get => m;
            set
            {
                if(1 <= value && value <= 10)
                {
                    m = value;
                }
                else
                {
                    throw new Exception("Value doesn't fit");
                }
            }
        }

        public InsertIntoArray(int n, int k, int m)
        {
            List = new List<int>(Enumerable.Range(1, n));
            N = n;
            K = k;
            M = m;
        }

        public InsertIntoArray(List<int> list, int n, int k, int m)
        {
            List = CreateList(list, n);
            N = n;
            K = k;
            M = m;
        }

        private List<int> CreateList(List<int> a, int size)
        {
            List<int> list = new List<int>();
            if(a.Count < size)
            {
                for (int i = 0; i != a.Count; ++i)
                {
                    list.Add(a[i]);
                }
                for (int i = a.Count; i != size; ++i)
                {
                    list.Add(1);
                }
            }
            else
            {
                for (int i = 0; i != size; ++i)
                {
                    list.Add(a[i]);
                }
            }
            return list;
        }

        public void Print()
        {
            foreach(int item in List)
            {
                Console.Write(item + " ");
            }
        }

        public void InsertToTheList()
        {
            for (int i = K, c = 0; c != M; ++c, ++i)
            {
                List.Insert(i, 0);
            }
        }
    }
}
