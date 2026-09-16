using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konstruktor
{
    public class auto
    {
        public string marka {  get; set; }
        public string tipus { get; set; }
        public int gyart_ev {  get; set; }
        public int eletkor { get; set; }

        public auto(string marka, string tipus, int gyart_ev)
        {
            marka = marka;
            tipus = tipus;
            gyart_ev = gyart_ev;
            eletkor = 2026 - gyart_ev;
        }
        public override string ToString()
        {
            return $"{marka},{tipus},{gyart_ev},{eletkor}";
        }
    }
}
