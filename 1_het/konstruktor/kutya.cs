using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konstruktor
{
    public class kutya
    {
        public string name {  get; set; }
        public string fajta { get; set; }
        public int eletkor { get; set; }

        public kutya(string name, string fajta, int eletkor)
        {
            name = name;
            fajta = fajta;
            eletkor = eletkor;
        }
        public override string ToString()
        {
            return $"{name} : {fajta} : {eletkor}";
            
        }
    }
}
