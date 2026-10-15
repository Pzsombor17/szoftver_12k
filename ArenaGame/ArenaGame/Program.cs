namespace ArenaGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            charachter test = new charachter("TExt");
            Console.WriteLine("TEST is alive: "+ test.IsAlive());
            Console.WriteLine("total number of charachters"+ charachter.Count);

            Warrior w = new Warrior("test",5);

            Console.WriteLine("Warrior name:" + w.Name);
            Console.WriteLine("Warrior health:" + w.Health);
            Console.WriteLine("Warrior name:" + w.Armor);
            Console.WriteLine(w.GetDescripiton());
        }
    }
}
