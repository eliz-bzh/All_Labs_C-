using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs_6_semester
{
    [Serializable]
    public class Actor
    {
        private string sex;
        private double mark;

        public String Name { get; set; }
        public String Surname { get; set; }
        public DateTime Birthday { get; set; }
        public String Sex
        {
            get => sex;
            set
            {
                if (value != "М" && value != "Ж")
                    throw new Exception("Ошибка!!!");
                sex = value;
            }
        }
        public string[] Genres { get; set; }
        public uint AmountFilms { get; set; }
        public uint AmountOscars { get; set; }
        public double Mark {
            get => mark;
            set
            {
                if(value > 10 && value < 0)
                    throw new Exception("Ошибка!!!");
                mark = value;
            }
        }

        public Actor() : this("Liz", "Bozhkova", new DateTime(2002, 1, 28), new string[]{ "F", "F", "F"}, "Ж", 2, 4, 7.4) { }
        public Actor(string name, string surname, DateTime birthday, string[] genres, string sex, uint amountFilms, uint amountOscars, double mark)
        {
            Name = name;
            Surname = surname;
            Birthday = birthday;
            if (genres.Length != 3)
                throw new Exception("Массив должен состоять из 3 жанров.");
            Genres = genres;
            Sex = sex;
            AmountFilms = amountFilms;
            AmountOscars = amountOscars;
            Mark = mark;
        }

        public override string ToString()
        {
            return string.Format("Name: {0}\nSurname: {1}\nBirthday: {2}\nSex: {3}\nAmountFilms: {4}\nAmountOscars: {5}\nMark: {6}\nGenres: {7}, {8}, {9} \n",
                Name, Surname, Birthday, Sex, AmountFilms, AmountOscars, Mark, Genres[0], Genres[1], Genres[2]);
        }
    }

    class Actors
    {
        public List<Actor> actors { get; set; }

        public Actors(){}

        public Actors(List<Actor> actors)
        {
            this.actors = actors;
        }

        public void Add(Actor st)
        {
            actors.Add(st);
        }

        public void SortDependentFilmsFIO()
        {
            var h = actors.OrderBy(el => el.AmountFilms).ThenBy(x => x.Name).ThenBy(el => el.Surname).ToList();
            foreach (var item in h)
            {
                Console.WriteLine(item);
            }
        }

        public void PrintDehendentBirthday()
        {
            var d = from el in actors 
                    group el by el.Birthday;
            foreach (var item in d)
            {
                Console.WriteLine(item.Key);
                foreach (var a in item)
                {
                    Console.WriteLine("\tName: " + a.Name + " Surname: " + a.Surname);
                }
            }
        }

        public void PopularActor()
        {
            var actor = actors.OrderByDescending(x => x.AmountFilms).ThenByDescending(x => x.AmountOscars).ToList();
            Console.WriteLine(actor[0]);
        }

        public void MaxMarkAmongMen()
        {
            var s = actors.Where(el => el.Sex == "М").Max(el => el.Mark);
            Console.WriteLine("Max Mark: " + s);
        }

        public void GroupAll()
        {
            var s = from el in actors
                    group el by el.Mark;
            foreach (var item in s) 
            {
                Console.Write(item.Key);
                foreach (var i in item)
                {
                    Console.WriteLine(" - " + i.Name);
                }
            }
        }
    }
}
