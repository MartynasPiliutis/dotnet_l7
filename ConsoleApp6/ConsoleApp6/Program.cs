using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Studentas[] studMasyvas = StudKortele.sukuriaStudentuMasyva();
            StudKortele.ParodoStudentoKorteleSuVildurkiais(studMasyvas);
            Console.ReadLine();
        }
    }
}
