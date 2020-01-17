using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Staciakampis staciakampis1 = new Staciakampis(10, 15);
            Staciakampis staciakampis2 = new Staciakampis(13, 13);
            Staciakampis staciakampis3 = new Staciakampis(8, 19);

            Console.WriteLine("Pirmo staciakampio ilgis: {0}, plotis: {1}. Staciakampio plotas: {2}", staciakampis1.StaciakampioIlgis, staciakampis1.StaciakampioPlotis, staciakampis1.PaskaiciuojaStaciakampioPlota());
            Console.WriteLine("Antro staciakampio ilgis: {0}, plotis: {1}. Staciakampio plotas: {2}", staciakampis2.StaciakampioIlgis, staciakampis2.StaciakampioPlotis, staciakampis2.PaskaiciuojaStaciakampioPlota());
            Console.WriteLine("Trecio staciakampio ilgis: {0}, plotis: {1}. Staciakampio plotas: {2}", staciakampis3.StaciakampioIlgis, staciakampis3.StaciakampioPlotis, staciakampis3.PaskaiciuojaStaciakampioPlota());
            Console.ReadLine();
        }
    }
}
