using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Labs
{
    public delegate int accumulate(int a, int b);

    class Program
    {
        public static int Accum(int[,] arr, accumulate ac)
        {
            int res = 0;
            for(int i = 0; i != arr.GetLength(0); ++i)
            {
                for(int j = 0; j != arr.GetLength(1); ++j)
                {
                    res = ac(res, arr[i,j]);
                }
            }
            return res;
        }
        public static int accum(int a, int b)
        {
            return a + b;
        }

        public interface IBinaryOperation
        {
            int accum(int a, int b);
        }

        public class Acuummulate : IBinaryOperation
        {
            public int accum(int a, int b)
            {
                return a + b;
            }
        }

        public static int acumArr(int[,] arr, IBinaryOperation op)
        {
            int res = 0;
            for(int i = 0; i != arr.GetLength(0); ++i)
            {
                for(int j = 0; j != arr.GetLength(1); ++j)
                {
                    res = op.accum(res, arr[i, j]);
                }
            }
            return res;
        }

        //class Base
        //{
        //    virtual public void f()
        //    {
        //        Console.WriteLine("Hello");
        //    }
        //}

        //class BaseB: Base
        //{
        //    override public void f()
        //    {
        //        Console.WriteLine("Hi");
        //    }
        //}
        /*class Time
        {
            private int hours;
            private int minutes;
            private int seconds;

            public Time() { }
            public Time(int hours, int minutes, int seconds)
            {
                this.hours = hours;
                this.minutes = minutes;
                this.seconds = seconds;
            }

            ~Time()
            {
                Console.WriteLine("Deleted");
            }

            public int firstMethod()
            {
                return this.minutes;
            }

            public void secondMethod()
            {
                this.minutes -= 10;
            }

            public override string ToString()
            {
                return "hours " + hours.ToString() + "\nminutes " + minutes.ToString() + "\nseconds " + seconds.ToString();
            }
        }*/

        public static void FillArray(int[,] array)
        {
            Random random = new Random();
            for(int i = 0; i != array.GetLength(0); ++i)
            {
                for(int j = 0; j!= array.GetLength(1); ++j)
                {
                    array[i, j] = random.Next();
                }
            }
        }


        static void Main(string[] args)
        {
            /*int[,] array = new int[2, 2];
            FillArray(array);
            for (int i = 0; i != array.GetLength(0); ++i)
            {
                for (int j = 0; j != array.GetLength(1); ++j)
                {
                    Console.Write(array[i,j] + "\t");
                }
                Console.WriteLine();
            }*/

            /*string str = "345-44-44";
            Regex regex = new Regex(@"\d{3}-\d{2}-\d{2}");
            Console.WriteLine(regex.Match(str));
            */


            /*
            int[] arr = new int[1];
            var arr1 = new int[1];
            var arr2 = new int[] { 1, 2, 3 };
            //int[] arr3 = new int[] { 10, -1, 2, 3 };
            int[] arr4 = { 1, 2, 3 };
            int[] arr5 = (new List<int>() { 1, 2, 3 }).ToArray();
            Array arr6 = new int[]{ 1, 23, 3};
            Array arr7 = new int[,] { { 1, 23, 3 }, { 4, 5, 6 } };
            int[,] arr8 = { { 1, 2, 3 }, { 4, 5, 6 } };
            int[,] arr9 = new int[2,2] { { 1, 4 },{ 2, 3 } };
            List<List<int>> arr10 = new List<List<int>>();

            int[] arr3 = new int[] { 10, -1, 2, 3 };
            Array.Sort(arr3);
            foreach(int i in arr3)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(Array.BinarySearch(arr3, 23));
            int[] res = Array.FindAll(arr3, (int a) => { return a < 0; });
            foreach (int i in res)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(Array.IndexOf(arr3, -1));
            Array.Clear(arr3, 0, arr3.Length);*/


            /*
            //7
            LizKPiIP.LengthSquare(3);
            int[] arr12 = new int[] { 1, 2, 3 };
            int[] arr22 = new int[] { 1, 2, 3 };
            int[] res = LizKPiIP.SortCopyArray(arr12, arr22);
            foreach(var i in res)
            {
                Console.Write(i + " ");
            }
            */

            /*
            //8
            Lab8.WriteToFile();
            Console.WriteLine(Lab8.SumNumbers());
            */

            /*
            //9
            List<Student> students = new List<Student>(){
                new Student("Liz", "T-795", 7.6, 50),
                new Student("Vano", "T-795", 6, 90),
                new Student("Kate", "T-795", 6, 8850),
                new Student("Dasha", "T-795", 7.7, 700)
            };
            Students st = new Students(students);
            st.CreateResList();
            st.PrintList();
            */


            //int[,] arr1 = new int[3, 3] 
            //{
            //                   { 1, 2, 0 },
            //                   { 1, 0, 3 },
            //                   { 0, 2, 3 }
            //};
            // Console.WriteLine(Accum(arr1, accum));
            //Console.WriteLine(acumArr(arr1, new Acuummulate()));


            //A temp = new B();// коммент ctrl+k потом с
            //temp.f();
            //Base d = new BaseB();
            //d.f();






            /*Time newTime = new Time(12, 4, 5);
            int m = newTime.firstMethod();
            newTime.secondMethod();
            Console.WriteLine(m);
            Console.WriteLine(newTime.ToString());*/


            /*Labs.ChangeConsoleColor("\tЭти люди говорили, что между ранними легендами есть существенное сходство, в том числе - в деталях, и что во многом вермонтские холмы остаются до конце не исследованными, так что было бы неразумно походя отметать вероятность наличия там загадочных обитателей; нельзя было убедить моих упрямых друзей и в том, что, как известно, все мифы имеют общую структуру и объясняются одним и тем же типом искажения реальности, порожденным ранней стадией, развития мышления человека.\n\tНе было смысла демонстрировать таким оппонентам, что вермонтские мифы по существу мало отличались от тех всеобщих легенд о природной персонификации, которые наполнили античный мир фавнами, дриадами и сатирами, предположили существование калликанзараев в Греции и дали диким уэльсцам и ирландцам возможность предположить существование странных, маленьких и тщательно спрятанных племен троглодитов и обитателей земляных нор.Бесполезно было также напоминать им о вере непальских горных племен в существование страшного Ми - Го или «Отвратительного Снежного Человека», таящегося посреди ледяных и горных шпилей Гималаев.");
            Labs.LengthSquare(4);
            Console.WriteLine(Labs.ConvertByteKilobytes(5011));
            Console.WriteLine(Labs.geometricProgression(124));
            Labs.f4();
            Console.WriteLine(Labs.triangle(1,1,1));
            Console.WriteLine(Labs.F7(0,3,4));
            Labs.F8();

            //2
            Console.WriteLine(Labs.f1(0));

            double[] array = new double[4];
            Console.WriteLine(Dasha.SubFirstSecond(array));
            

            int[,] mat = new int[3,3]
            {
                                { 1, 2, 0 },
                               { 1, 0, 3 },
                               { 0, 2, 3 }
            };
            int[,] m = new int[3, 3]
                {
                               { 1, 2, 0 },
                               { 1, 0, 3 },
                               { 0, 2, 3 }
                            };

            Console.WriteLine(Dasha.MulMatrix(mat, m));
            Dasha.SumGreaterOfArif(4);*/





            //Console.WriteLine(LizKPiIP.fillArray(arr, 10));
            //LizKPiIP.DateTimes(10);
            //Console.WriteLine(LizKPiIP.ConverTo());

            /*int n = Convert.ToInt32(Console.ReadLine(), 2);
            Console.WriteLine(LizKPiIP.ConverTo(n));*/

            byte b = 5;
            double d = b;
            //Console.WriteLine(d);
            //7
            /*LizKPiIP.LengthSquare(2);
            List<int> l = new List<int> { 1, 2, 3 };
            List<int> l2 = new List<int> { 1, 2, 3 };
            Console.WriteLine(LizKPiIP.SortCopyArray(l, l2));*/

            //IEnumerable<int> someCollection = null;//типы приведения
            //(преобразования)
            //IConvertible
            //()
            //as
            //Convert
            //List<int> list = someCollection as List<int>;//1 тип 
            //List<int> list1 = (List<int>)someCollection;// 2 тип
            int a = 10;
            a = (++a) - 5;
            switch (a)
            {
                case 5: { Console.WriteLine("(a++) - 5 = " + a); break; }
                case 6: { Console.WriteLine("(++a) - 5 = " + a); break; }
                default:
                    Console.WriteLine("default");
                    break;
            }

            /*
            //for
            for(инициализация счётчика; условие; шаг для изм счётчика) { }
            //foreach
            foreach (условие) { }//для перебора коллекции
            //while
            while (усдовие) {...; шаг}
            //do...while
            do{}while(условие)
            */
            /*continue and break
            for (int i = 0; i < 9; i++)
            {
                if (i == 5)
                    break;
                Console.WriteLine(i);
            } ОТВЕТ: 0 1 2 3 4

            for (int i = 0; i < 9; i++)
            {
                if (i == 5)
                    continue;
                Console.WriteLine(i);
            } ОТВЕТ: 0 1 2 3 4 6 7 8
            */



            Console.ReadLine();
        }
    }
}
