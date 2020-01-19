using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
	struct Studentas
	{
		public int StudentoID;
		public int[] Trimestras1;
		public int[] Trimestras2;
		public int[] Trimestras3;

		public Studentas(int id, int[] t1, int[] t2, int[] t3)
		{
			StudentoID = id;
			Trimestras1 = t1;
			Trimestras2 = t2;
			Trimestras3 = t3;
		}

		public double PaskaiciuojaTrimestroVidurki(int[] trimestras)
		{
			int trimestroSuma = 0;
			for (int i = 0; i < trimestras.Length; i++)
			{
				trimestroSuma += trimestras[i];
			}
			double trimestroVidurkis = Convert.ToDouble(trimestroSuma) / trimestras.Length;
			return trimestroVidurkis;
		}

		public double PaskaiciuojaMetiniVidurki(int[] Trimestras1, int[] Trimestras2, int[] Trimestras3)
		{
			int trimestruSuma = 0;
			for (int i = 0; i < Trimestras1.Length; i++)
			{
				trimestruSuma += Trimestras1[i];
			}

			for (int i = 0; i < Trimestras2.Length; i++)
			{
				trimestruSuma += Trimestras2[i];
			}

			for (int i = 0; i < Trimestras3.Length; i++)
			{
				trimestruSuma += Trimestras3[i];
			}

			double metinisVidurkis = Convert.ToDouble(trimestruSuma) / (Trimestras1.Length + Trimestras2.Length + Trimestras3.Length);
			return metinisVidurkis;
		}
	}

}
