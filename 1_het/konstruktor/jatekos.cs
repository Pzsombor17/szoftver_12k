using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konstruktor
{
    public class jatekos
    {
        public string name { get; set; }
        public int szint { get; set; }
        public int pontszam { get; set; }

        public jatekos(string name,int szint = 1 ,int pontszam = 0)
        {
            name = name;
            szint = szint;
            pontszam = pontszam;
        }
        public override string ToString()
        {
            return $"{name}, {szint}, {pontszam}";
        }
    }
}
