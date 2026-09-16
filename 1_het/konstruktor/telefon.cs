using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konstruktor
{
    public class telefon
    {
        public string marka {  get; set; }
        public string tipus { get; set; }
        public int ar {  get; set; }

        public telefon(string marka,string tipus, int ar = 100000)
        {
            marka = marka;
            tipus = tipus;
            ar = ar;
        }
       public override string ToString()
        {
            return $"{marka},{tipus},{ar}";
        }
    }
}
