namespace ArenaGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            charachter test = new charachter("TExt");
            Console.WriteLine("TEST is alive: "+ test.IsAlive());
            Console.WriteLine("total number of charachters"+ charachter.Count);

            Warrior w = new Warrior("test",5);

            Console.WriteLine("Warrior name:" + w.Name);
            Console.WriteLine("Warrior health:" + w.Health);
            Console.WriteLine("Warrior name:" + w.Armor);
            Console.WriteLine(w.GetDescripiton());

            mage m = new mage("m", 15);

            Console.WriteLine("Mage name: "+ m.Name);
            Console.WriteLine("Mage name: "+ m.Health);
            Console.WriteLine("Mage name: "+ m.Mana);
            Console.WriteLine(m.GetDescripiton());

            Console.WriteLine("Total number of charachters:"+ charachter.Count);

            Console.WriteLine("Warrior health"+ w.Health);
            Console.WriteLine("Warrior health"+ w.TakeDamage(30));
            Console.WriteLine("Warrior health"+ w.Health);
            Console.WriteLine("Warrior health"+ w.Heal(4));
            Console.WriteLine("Warrior health"+ w.Health);
            Console.WriteLine("Warrior health"+ w.Health);
            Console.WriteLine("Warrior health"+ w.Health);
            Console.WriteLine("Warrior health"+ w.Health);
            Console.WriteLine("Warrior health"+ w.Health);
            Console.WriteLine("Warrior health"+ w.Health);
        }
    }
}
