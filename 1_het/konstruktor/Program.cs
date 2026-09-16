namespace konstruktor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            kutya dog1 = new kutya("Bodri","Labrador",5);
            kutya dog2 = new kutya("Morzsi","Beagle",3);
            telefon tel1 = new telefon("Samsung","Galaxy S24");
            telefon tel2 = new telefon("Apple", "iphone 16",350000);
            jatekos jatekos1 = new jatekos("Steve");
            jatekos jatekos2 = new jatekos("Alex",5,1200);
            auto a1 = new auto("Toyota","Corolla",2018);
            auto a2 = new auto("BMW", "320i", 2021);
            film f1 = new film("Interstellar",8.7);
            film f2 = new film("Minecraft Movie", 5.6);
        }
    }
}
