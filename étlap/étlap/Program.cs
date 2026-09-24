using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace étlap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fajl = @"C:\Users\zsomb\Downloads\zsar_edit.mp4";

            Process.Start(new ProcessStartInfo
            {
                FileName = fajl,
                UseShellExecute = true
            });
            MenuItem bolognai = new MenuItem("bolognai","tészta",1000);
            MenuItem carbonara = new MenuItem("carbonara", "tészta", 2000);
            ConsoleView consoleView = new ConsoleView();
            consoleView.ShowItem(bolognai);
            consoleView.ShowItem(carbonara);
            MenuItem almale = new MenuItem("almale", "ital", 1000);
            MenuItem cappy = new MenuItem("cappy", "ital", 2000);
            MenuItem vadas = new MenuItem("vadas", "etel", 1000);
            MenuItem rantotthus = new MenuItem("rantotthus", "etel", 2000);
            MenuItem vajaskenyer = new MenuItem("vajaskenyer", "etel", 1000);
            
            List<MenuItem> foodList = new List<MenuItem>();
            foodList.Add(almale);
            foodList.Add(carbonara);
            foodList.Add(cappy);
            foodList.Add(vadas);
            foodList.Add(rantotthus);

            consoleView.ShowItems(foodList);
            foodList.Count();
            consoleView.ShowMessage(MenuItem.Count.ToString());
            Menu menu = new Menu("WOW");

            menu.AddItem(cappy);
            if(menu.FindByName("B") != null && menu.FindByName("B").GetDescription() == "A")    
            {
                consoleView.ShowItem(menu.FindByName("B"));
            }
            else
            {
                consoleView.ShowMessage("Nincs ilyen elem!!");
            }
            
        }
    }
}
