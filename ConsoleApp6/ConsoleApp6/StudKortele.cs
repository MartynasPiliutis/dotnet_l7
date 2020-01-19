using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp6
{
    struct StudKortele
    {
        public static void ParodoStudentoKorteleSuVildurkiais(Studentas[] studMasyvas)
        {
            foreach (var item in studMasyvas)
            {
                Console.WriteLine("*****************************************");
                Console.WriteLine("Studento ID: {0}", item.StudentoID);
                Console.WriteLine("=========================================");
                for (int i = 1; i <= 3; i++)
                {
                    if (i == 1)
                    {
                        string trimNr = "PIRMAS TRIMESTRAS";
                        int[] trimestras = item.Trimestras1;
                        double vidurkis = item.PaskaiciuojaTrimestroVidurki(trimestras);
                        IsvedaIEkranaStudentoKortele(trimNr, vidurkis);
                    }
                    else if (i == 2)
                    {
                        string trimNr = "ANTRAS TRIMESTRAS";
                        int[] trimestras = item.Trimestras2;
                        double vidurkis = item.PaskaiciuojaTrimestroVidurki(trimestras);
                        IsvedaIEkranaStudentoKortele(trimNr, vidurkis);

                    }
                    else if (i == 3)
                    {
                        string trimNr = "TRECIAS TRIMESTRAS";
                        int[] trimestras = item.Trimestras3;
                        double vidurkis = item.PaskaiciuojaTrimestroVidurki(trimestras);
                        IsvedaIEkranaStudentoKortele(trimNr, vidurkis);

                    }
                }
                IsvedaIEkranaMetiniVidurki(item);
            }
        }

        private static void IsvedaIEkranaMetiniVidurki(Studentas item)
        {
            double metVidurkis = item.PaskaiciuojaMetiniVidurki(item.Trimestras1, item.Trimestras2, item.Trimestras3);
            Console.WriteLine("METINIS VIDURKIS: {0} ({1})", Math.Round(metVidurkis, 0), Math.Round(metVidurkis, 2));
            Console.WriteLine("*****************************************");
            Console.WriteLine();
            Console.WriteLine();
        }

        private static void IsvedaIEkranaStudentoKortele(string trimNr, double vidurkis)
        {
            Console.WriteLine(trimNr);
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Trimestro vidurkis: {0} ({1})", Math.Round(vidurkis, 0), Math.Round(vidurkis, 2));
            Console.WriteLine("=========================================");
        }

        public static Studentas[] SukuriaStudentuMasyva()
        {
            Studentas[] studMasyvas = new Studentas[5];
            studMasyvas[0] = new Studentas(12345987, new int[] { 10, 6, 9, 9, 9, 10, 5, 8 }, new int[] { 7, 5, 9, 7, 9, 10, 10, 6, 8 }, new int[] { 10, 5, 9, 8, 9 });
            studMasyvas[1] = new Studentas(54125131, new int[] { 5, 8, 10, 9, 5, 7 }, new int[] { 5, 9, 8, 10, 6, 8, 7 }, new int[] { 10, 9, 9, 10, 8, 6 });
            studMasyvas[2] = new Studentas(78651326, new int[] { 10, 10, 9, 8, 9, 10, 8, 9 }, new int[] { 9, 9, 8, 9, 10, 7, 10, 10 }, new int[] { 7, 10, 10, 9, 8, 10, 10 });
            studMasyvas[3] = new Studentas(75324185, new int[] { 6, 7, 6, 5, 6, 6, 7 }, new int[] { 6, 7, 8, 7, 9, 10 }, new int[] { 7, 6, 8, 7, 9, 9 });
            studMasyvas[4] = new Studentas(32510555, new int[] { 10, 8, 8, 9, 8, 7, 8, 10 }, new int[] { 7, 8, 9, 9, 8, 5, 9 }, new int[] { 10, 10, 9, 9, 8, 9, 10 });
            return studMasyvas;
        }

    }
}
