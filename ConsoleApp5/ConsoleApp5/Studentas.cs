using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    struct Studentas
    {
        public string VardasPavarde;
        public int StudentoID;
        public bool Iskaita;

        public Studentas(string name, int stud_id, bool pass)
        {
            VardasPavarde = name;
            StudentoID = stud_id;
            Iskaita = pass;
        } 
    }
}
