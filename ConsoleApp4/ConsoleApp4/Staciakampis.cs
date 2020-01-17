using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
	struct Staciakampis
	{
		public int StaciakampioIlgis;
		public int StaciakampioPlotis;

		public Staciakampis(int sIlgis, int sPlotis)
		{
			StaciakampioIlgis = sIlgis;
			StaciakampioPlotis = sPlotis;
		}

		public int PaskaiciuojaStaciakampioPlota()
		{
			return StaciakampioIlgis * StaciakampioPlotis;
		}
	}
}
