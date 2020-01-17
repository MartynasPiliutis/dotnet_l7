using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    struct Mokinys
    {
        public string vardas;
        public string pavarde;
        public DateTime start;
        public DateTime end;

        public Mokinys(string name, string lname, DateTime startd, DateTime endd)
        {
            vardas = name;
            pavarde = lname;
            start = startd;
            end = endd;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {

            Mokinys[] mokiniuMasyvas = new Mokinys[4];
            mokiniuMasyvas[0] = new Mokinys("Martynas", "Piliutis", new DateTime(2019, 9, 1), new DateTime(2020, 5, 31));
            mokiniuMasyvas[1] = new Mokinys("Tomas", "Farsas", new DateTime(2019, 9, 1), new DateTime(2020, 5, 31));
            mokiniuMasyvas[2] = new Mokinys("Petras", "Rope", new DateTime(2019, 9, 1), new DateTime(2020, 5, 31));
            mokiniuMasyvas[3] = new Mokinys("Jonas", "Druskis", new DateTime(2019, 9, 1), new DateTime(2020, 5, 31));
            
            foreach (var item in mokiniuMasyvas)
            {
                Console.WriteLine(item.vardas + " " + item.pavarde + " " + item.start.ToString("yyyy/MM/dd") + " " + item.end.ToString("yyyy/MM/dd"));
            }
            Console.ReadLine();
        }
    }
}
