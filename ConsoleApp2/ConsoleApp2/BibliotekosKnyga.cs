using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    struct BibliotekosKnyga
    {
        int KnygosID;
        public string KnygosPavadinimas;
        public string SkaitytojoVardas;
        public DateTime PaemimoData;

        public BibliotekosKnyga(int bookid, string bname, string uname, DateTime pdate)
        {
            KnygosID = bookid;
            KnygosPavadinimas = bname;
            SkaitytojoVardas = uname;
            PaemimoData = pdate;
        }

        public int PaskaiciuojaDienas()
        {
            DateTime today = DateTime.Now;
            DateTime start = PaemimoData;
            int dienos = (today - start).Days;
            return dienos;
        }

    }

}
