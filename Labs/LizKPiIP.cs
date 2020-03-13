using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs
{
    class LizKPiIP
    {
        //5
        public static StringBuilder ConvertionSB(String s, int n)
        {
            StringBuilder sb = new StringBuilder(s);
            if (sb.Length > n)
            {
                sb.Remove(0, sb.Length - n - 1);
            }
            else if(sb.Length < n)
            {
                for(int i = sb.Length; i != n; ++i)
                {
                    sb.Insert(0, ".");
                }
            }
            return sb;
        }

        public static string ConvertionString(string s, int n)
        {
            if (s.Length > n)
            {
                s = s.Substring(s.Length - n, n);
            }
            else if (s.Length < n)
            {
                for (int i = s.Length; i != n; ++i)
                {
                    s = s.Insert(0, ".");
                }
            }
            return s;
        }

        public static List<char> ConvertionChar(string s, int n)
        {
            List<char> charl = s.ToCharArray().ToList();
            if (s.Length > n)
            {
                charl = charl.GetRange(n, s.Length - n - 1);
            }
            else if (s.Length < n)
            {
                for (int i = charl.Count; i != n; i++)
                {
                    charl.Insert(0, '.');
                }
            }
            return charl;
        }

        //6
        public static DateTime[] fillArray(int n)
        {
            DateTime[] arr = new DateTime[n];
            Random random = new Random();
            DateTime start = new DateTime(2019, 11, 1, random.Next(6, 24), random.Next(0, 60), random.Next(0, 60));
            for (int i = 0; i != n; ++i)
            {
                arr[i] = start.AddHours(random.Next(0, 24)).AddMinutes(random.Next(0, 60)).AddSeconds(random.Next(0, 60));
                Console.WriteLine(arr[i]);
            }
            return arr;
        }

        public static void Print(List<DateTime> dates)
        {
            for(int i = 0; i != dates.Count(); ++i)
            {
                Console.WriteLine(dates[i]);
            }
        }

        public static void DateTimes(int size)
        {
            DateTime[] dates = fillArray(size);
            DateTime startTime = new DateTime(2019, 11, 1, 7, 0, 0);
            List<DateTime> firstShift = new List<DateTime>();
            List<DateTime> secondShift = new List<DateTime>();
            for (int i = 0; i != dates.Length; ++i)
            {
                if (dates[i].Hour >= 7 && 14 >= dates[i].Hour)
                {
                    firstShift.Add(dates[i]);
                }
                if(dates[i].Hour >= 15 && 20 >= dates[i].Hour)
                {
                    secondShift.Add(dates[i]);
                }
            }
            Console.WriteLine("Fisrt shift");
            Print(firstShift);
            Console.WriteLine("Second shift");
            Print(secondShift);
        }

        public static string ConverTo(int value)
        {
            return String.Format("{0:X}", Convert.ToString(value, 16));
        }


        //7
        public static double Pow(double number, int pow)
        {
            double res = 1;
            for(int i = 0; i != pow; ++i)
            {
                res *= number;
            }
            return res;
        }

        public static void LengthSquare(double r)
        {
            Console.WriteLine("Circumference" + " = " + (Math.PI * (r * 2)));
            Console.WriteLine("Area of a circle" + " = " + (Math.PI * Pow(r, 2)));
        }

        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public static void SortArr(int[] arr)
        {
            for (int i = 0; i != arr.Length; ++i)
            {
                for (int j = 0; j != arr.Length - 1; ++j)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        Swap(ref arr[j], ref arr[j + 1]);
                    }
                }
            }
        }

        public static int[] SortCopyArray(int[] arr, int[] arr1)
        {
            int[] res = arr.Concat(arr1).ToArray();
            SortArr(res);
            return res;
        }
    }
}
