using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Labs
{
    class Lab8
    {
        private static string path = @"C:\Users\Liz\Desktop\GG.txt";
        public static void WriteToFile()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(path))//жизненный цикл объекта
                {
                    for (int i = 1; i <= 500; ++i)
                    {
                        sw.Write(Convert.ToString(i));
                        if(i != 500)
                        {
                            sw.Write(", ");
                        }
                    }
                }
                Console.WriteLine("Норм файл");
            }
            catch
            {
                Console.WriteLine("Возникло исключение");
            }
        }

        public static int SumNumbers()
        {
            string strData = File.ReadAllText(path);
            string[] strNumbers = strData.Split(',');
            int res = 0;
            foreach (string item in strNumbers)
            {
                res += Convert.ToInt32(item);
            }
            return res;
        }
    }
}
