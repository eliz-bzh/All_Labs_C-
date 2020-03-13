using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using System.Threading;

namespace Labs_6_semester
{
    class Program
    {
        static void Main(string[] args)
        {
            //20
            Actors actors = new Actors(new List<Actor>
            {
                new Actor("Liz", "Bozhkova", new DateTime(2002, 1, 28), new string[]{"Horror", "Comedy", "Romane"}, "Ж", 2, 1, 9),
                new Actor("Men", "Fi", new DateTime(2001, 10, 8), new string[]{"Horror", "Comedy", "Romane"}, "М", 6, 2, 8),
                new Actor("Dasha", "Korob", new DateTime(2001, 10, 8), new string[]{"Horror", "Comedy", "Romane"}, "Ж", 4, 2, 6.9),
                new Actor("Vano", "Vantuz", new DateTime(2001, 10, 8), new string[]{"Horror", "Comedy", "Romane"}, "М", 3, 3, 7)
            });
            //actors.SortDependentFilmsFIO();
            //actors.PrintDehendentBirthday();
            //actors.PopularActor();
            //actors.MaxMarkAmongMen();
            //actors.GroupAll();

            //21
            //XmlSerializer xmlSerializer = new XmlSerializer(typeof(Actor));
            //using (FileStream fs = new FileStream("Lab21.xml", FileMode.OpenOrCreate))
            //{
            //    for (int i = 0; i < actors.actors.Count; i++)
            //    {
            //        xmlSerializer.Serialize(fs, actors.actors[i]);
            //    }
            //    Console.WriteLine("Object serialized like xml");
            //}

            //22
            Thread th1 = new Thread(new ThreadStart(Teams.AddPlayers));
            Thread th2 = new Thread(new ThreadStart(Teams.RemovePlayers));
            Thread th3 = new Thread(new ThreadStart(Teams.Print));

            th1.Start();
            th2.Start();
            th3.Start();

            Console.ReadKey();
        }
    }
}
