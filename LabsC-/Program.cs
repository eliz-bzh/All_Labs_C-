using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.IO;
using System.Xml.Serialization;
using MyLib;

namespace LabsC_
{
    class Program
    {
        static void Main(string[] args)
        {
            //10.1
            //Lab10_1 lab = new Lab10_1(1, 2);
            //Console.WriteLine(lab.Product());

            //10.2
            Polynomial polynomial = new Polynomial(new List<Monomial>
            {
                new Monomial(2,4),
                new Monomial(1,3),
                new Monomial(2,2),
                new Monomial(3,1)
            });

            Polynomial polynomial1 = new Polynomial(new List<Monomial>
            {
                new Monomial(2,3),
                new Monomial(3,2),
                new Monomial(4,1)
            });

            Polynomial sum = Polynomial.OperationsMonomial(
                polynomial,
                polynomial1,
                (a, b) => { return a + b; }
            );

            //Polynomial res = polynomial * polynomial1;
            //res.CreateResList();
            //res.PrintList();

            //sum.PrintList();

            //Console.WriteLine(polynomial1.ValueCalculation(2));
            //Console.WriteLine(polynomial1.GettingCoefficient(-3));

            //12.2
            //Создать клон разработанного класса
            MailAdress mailAdress = new MailAdress();
            MailAdress lab = (MailAdress)mailAdress.Clone();
            //Console.WriteLine(lab);

            //Отсортировать массив по одному критерию сортировки
            MailAdress[] mailAdresses = new MailAdress[]{
                new MailAdress(),
                new MailAdress(32214, "Minsk", "Minsk", "Minsk", "Nemiga", 11),
                new MailAdress(23, "Minsk", "Minsk", "Minsk", "Nemiga", 1)
            };
            //Array.Sort(mailAdresses);
            //foreach (var item in mailAdresses)
            //{
            //    Console.WriteLine(item);
            //}

            //Отсортировать массив по нескольким (заданным) критериям сортировки
            Array.Sort(mailAdresses, new MailAdressComparer());
            //foreach (var item in mailAdresses)
            //{
            //    Console.WriteLine(item);
            //}

            //13.1.1
            Circle circle = new Circle(2);
            //Console.WriteLine(circle.Circumference);
            //Console.WriteLine(circle.AreaOfTheCircle);

            //13.1.2
            List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7 };
            InsertIntoArray array = new InsertIntoArray(list, 8, 2, 2);
            //array.InsertToTheList();
            //array.Print();

            //13.2
            //Employees employees = new Employees(new List<Employee>
            //{
            //    new Employee("Bozhkova", "Liz", "Yuryevna", 344563, 144, 2),
            //    new Employee("Korobanko", "Daria", "Nikolaevna", 123534, 150, 2),
            //    new Employee("Vygovskaya", "Ekaterina", "Ruslanovna", 435476, 129, 1.5)
            //});
            //employees.PrintList();

            //14.1
            //Console.WriteLine("Tan(x): " + Delegate14.FunctionValue(3, Math.Tan));
            //Console.WriteLine("Ctg(x): " + 1 / Delegate14.FunctionValue(3, Math.Tan));

            //14.2 15
            //Employees employees = new Employees(new List<Employee>
            //{
            //    new Employee("Bozhkova", "Liz", "Yuryevna", 344563, 144, 2),
            //    new Employee("Korobanko", "Daria", "Nikolaevna", 123534, 150, 2),
            //    new Employee("Vygovskaya", "Ekaterina", "Ruslanovna", 435476, 129, 1.5)
            //});


            //16

            //XmlSerializer xmlSerializer = new XmlSerializer(typeof(Lab10_1));
            //SoapFormatter soap = new SoapFormatter();
            //BinaryFormatter binaryFormatter = new BinaryFormatter();

            //using (FileStream fs = new FileStream("Lab10_1.dat", FileMode.OpenOrCreate))
            //{
            //    binaryFormatter.Serialize(fs, new Lab10_1());
            //    Console.WriteLine("Object serialized like Binary");
            //}

            //using (FileStream fs = new FileStream("Lab10_1.soap", FileMode.OpenOrCreate))
            //{
            //    soap.Serialize(fs, new Lab10_1());
            //    Console.WriteLine("Object serialized like soap");
            //}

            //using (FileStream fs = new FileStream("Lab10_1.xml", FileMode.OpenOrCreate))
            //{
            //    xmlSerializer.Serialize(fs, new Lab10_1());
            //    Console.WriteLine("Object serialized like xml");
            //}
            //return;

            //17.1
            //Сset<int> cset = new Сset<int>(new List<int> { 1, 23, 4, 3, 5 });
            //Сset<int> cset2 = new Сset<int>(new List<int> { 2, 5, 4, 0 });
            //Сset<int> res = cset * cset2;

            //res.Print(); // 5 4
            //Console.WriteLine(cset == cset2); // False

            //17.2


            //18
            Time time = new Time();
            Time restime = time.TimeInterval();
            Console.WriteLine(restime);
            Console.WriteLine(Time.ConvertToSeconds(new Time(2, 3, 5)));
            Console.ReadKey();
        }
    }
}
