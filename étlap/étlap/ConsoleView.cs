using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace étlap
{
    public class ConsoleView
    {
        public void ShowItem(MenuItem item)
        {
            Console.WriteLine(item.GetDescription());
        }
        public void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
        public void ShowItems(List<MenuItem> Items)
        {
            Items.ForEach(x=> ShowItem(x));
        }
        
    }
}
