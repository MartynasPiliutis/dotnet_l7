using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            BibliotekosKnyga book1 = new BibliotekosKnyga(1001, "Karibu Piratai", "Vardenis Pavardenis", new DateTime(2005, 12, 2));
            BibliotekosKnyga book2 = new BibliotekosKnyga(1002, "Niezulys", "Jonas Jonaitis", new DateTime(2010, 10, 10));
            BibliotekosKnyga book3 = new BibliotekosKnyga(1003, "Patranku Mesa", "Petras Petraitis", new DateTime(2020, 1, 2));
            BibliotekosKnyga book4 = new BibliotekosKnyga(1004, "Ratai", "Antanas Antanaitis", new DateTime(2016, 2, 29));
            BibliotekosKnyga book5 = new BibliotekosKnyga(1004, "Mohikanas", "Giedrius Giedraitis", new DateTime(2017, 2, 28));

            Console.WriteLine(book1.SkaitytojoVardas + " " + book1.PaskaiciuojaDienas());
            Console.WriteLine(book2.SkaitytojoVardas + " " + book2.PaskaiciuojaDienas());
            Console.WriteLine(book3.SkaitytojoVardas + " " + book3.PaskaiciuojaDienas());
            Console.WriteLine(book4.SkaitytojoVardas + " " + book4.PaskaiciuojaDienas());
            Console.WriteLine(book5.SkaitytojoVardas + " " + book5.PaskaiciuojaDienas());
            Console.ReadLine();

        }
    }
}
