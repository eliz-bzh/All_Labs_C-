using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabsC_
{
    class MailAdress : ICloneable, IComparable<MailAdress>
    {
        private int index;
        private string region;
        private string district;
        private string city;
        private string street;
        private int house;

        public int Index { get => index; set => index = value; }
        public string Region { get => region; set => region = value; }
        public string District { get => district; set => district = value; }
        public string City { get => city; set => city = value; }
        public string Street { get => street; set => street = value; }
        public int House { get => house; set => house = value; }

        public MailAdress() : this( 23451, "Minsk", "Minsk", "Minsk", "Nemiga", 6) { }
        public MailAdress(int index, string region, string district, string city, string street, int house)
        {
            this.Index = index;
            this.Region = region;
            this.District = district;
            this.City = city;
            this.Street = street;
            this.House = house;
        }

        public override string ToString()
        {
            return "Index: " + Index + "\n" +
                    "Region: " + Region + " region\n" +
                    "Disrict: " + District + " district\n" +
                    "City: " + City + "\n" +
                    "Street: " + Street + " street\n" + 
                    "House: № " + House + "\n";
        }

        public static MailAdress vvod()
        {
            Console.WriteLine("Enter the data:");
            Console.Write("Index: ");
            int index = Convert.ToInt32(Console.ReadLine());
            Console.Write("Region: ");
            string region = Console.ReadLine();
            Console.Write("District: ");
            string district = Console.ReadLine();
            Console.Write("City: ");
            string city = Console.ReadLine();
            Console.Write("Street: ");
            string street = Console.ReadLine();
            Console.Write("House: № ");
            int house = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            return new MailAdress(index, region, district, city, street, house);
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public int CompareTo(MailAdress other)
        {
            return this.Index.CompareTo(other.Index);
        }

    }
}
