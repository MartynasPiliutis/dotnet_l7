using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Studentas[] studentuMasyvas = sukuriaNaujaMasyvaSuStudentais();
            List<Studentas> studentai = sukuriaListaIrUzpildoDuomenimisIsMasyvo(studentuMasyvas);
            atspausdinaStudentMasyva(studentuMasyvas);
            Console.ReadLine();
            spausdinaUzpildytaLista(studentai);
            Console.ReadLine();
        }

        private static List<Studentas> sukuriaListaIrUzpildoDuomenimisIsMasyvo(Studentas[] studentuMasyvas)
        {
            List<Studentas> studentai = new List<Studentas>();
            studentai.AddRange(studentuMasyvas);
            return studentai;
        }

        private static Studentas[] sukuriaNaujaMasyvaSuStudentais()
        {
            Studentas[] studentuMasyvas = new Studentas[5];
            studentuMasyvas[0] = new Studentas("Jonas Jonaitis", 10201, true);
            studentuMasyvas[1] = new Studentas("Petras Petraitis", 14522, true);
            studentuMasyvas[2] = new Studentas("Giedrius Giedraitis", 88547, false);
            studentuMasyvas[3] = new Studentas("Antanas Antanaitis", 10225, true);
            studentuMasyvas[4] = new Studentas("Tomas Tomaitis", 65228, false);
            return studentuMasyvas;
        }

        private static void spausdinaUzpildytaLista(List<Studentas> studentai)
        {
            foreach (var studentas in studentai)
            {
                Console.WriteLine(studentas.VardasPavarde + "/" + studentas.StudentoID + "/" + "{0}", studentas.Iskaita ? "Iskaityta" : "Neiskaityta");
            }
        }

        private static void atspausdinaStudentMasyva(Studentas[] studentuMasyvas)
        {
            foreach (var item in studentuMasyvas)
            {
                Console.WriteLine("Studento Kortele");
                Console.WriteLine("****************");
                Console.WriteLine($"Sudentas: {item.VardasPavarde}");
                Console.WriteLine($"Sudento ID: {item.StudentoID}");
                Console.WriteLine("Iskaita: {0}", item.Iskaita ? "Iskaityta" : "Neiskaityta");
                Console.WriteLine("****************");
                Console.WriteLine();
            }
        }

    }
}
