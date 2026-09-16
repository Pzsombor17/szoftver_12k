using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konstruktor
{
    public class film
    {
        public string cim {  get; set; }
        public double ertekeles { get; set; }
        public bool ajanlotte { get; set; }

        public film(string cim,double rating)
        {
            cim = cim;
            rating = rating;
            ajanlotte = rating > 7 ? true : false;
        }
        public override string ToString()
        {
            return $"{cim}, {ertekeles}, {ajanlotte}";
        }
    }
}
