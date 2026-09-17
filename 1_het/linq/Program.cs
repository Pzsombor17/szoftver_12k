namespace linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            model model = new model();
            Console.WriteLine(model.cars.Count);
            model.AfterYear(2016).ForEach(x => Console.WriteLine(x));
            model.StrongerHP(2016).ForEach(x => Console.WriteLine(x));
            model.StrongerHP(2016).ForEach(x => Console.WriteLine(x));
            Console.WriteLine(model.CountBrand("BMW"));
            if (model.IsBrand("BMW"))
            {
                Console.WriteLine("van");
            }
            else
            {
                Console.WriteLine("nem");
            }
            if (model.StrongerHorseP(200))
            {
                Console.WriteLine("van");
            }
            else
            {
                Console.WriteLine("nincs");
            }
            model.MinHpAndCheaper(150, 300000).ForEach(x => Console.WriteLine(""));
        }
    }
}
