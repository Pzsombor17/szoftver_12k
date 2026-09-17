using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace linq
{
    public class model
    {
        public List<car> cars = new List<car>();
        private void Import(string filename)
        {
            cars = File.ReadAllLines(filename).Skip(1).Select(x=> new car(x)).ToList();
            
        }
        public model()
        {
            Import("cars.txt");
        }
        public List<string> AfterYear(int year)
        {
            return cars.Where(x=> x.buildYear > year).Select(x=>x.type).ToList();
        }
        public List<string> StrongerHP(int hp)
        {
            return cars.Where(x => x.HP > hp).Select(x => x.type).ToList();
        }
        public List<string> CheaperCars(int maxPrice)
        {
            return cars.Where(x => x.price < maxPrice).Select(x=>x.type).ToList();
        }
        public int CountBrand(string Brand)
        {
            return cars.Where(x => x.brand == Brand).Count();
        }
        public bool IsBrand(string brand)
        {
            return cars.Any(x => x.brand == brand);
        }
        public bool StrongerHorseP(int hp)
        {
            return cars.Any(x => x.HP > hp);
        }
        public int MostExpensiveCar()
        {
            return cars.Max(x => x.price);
        }
        public double AvgBrand(string Brand)
        {
            return cars.Where(x => x.brand == Brand).Average(x => x.HP);
        }
        public double AvgCarsPrice()
        {
            return cars.Average(x => x.price);
        }
        public List<string> AscPrice()
        {
            return cars.OrderBy(x=> x.price).Select(x=>x.type).ToList();
        }
        public List<string> DescHP()
        {
            return cars.OrderByDescending(x => x.HP).Select(x => x.type).ToList();
        }
        public List<string> BetweenYears(int year1,int year2)
        {
            return cars.Where(x => x.buildYear > year1 && x.buildYear < year2).Select(x=>x.type).ToList();
        }
        public List<string> MinHpAndCheaper(int minhp, int maxprice)
        {
            return cars.Where(x => x.HP >= minhp && x.price < maxprice).Select(x => x.type).ToList();
        }
        public string YoungestCar()
        {
            return cars.OrderByDescending(x => x.buildYear).Select(X => X.type).First();
        }
        public string Youngest1Car()
        {
            return cars.OrderByDescending(x => x.buildYear).Select(X => X.type).First();
        }
        public List<string> Asd(int db)
        {
            return cars.OrderByDescending(x=> x.price).Select(x => x.type).Take(db).ToList();
        }
        public List<string> BrandOrderByHp(string Brand)
        {
            return cars.Where(x=> x.brand == Brand).OrderByDescending(x=> x.HP).Select(x=> x.type).ToList();
        }
        public int BuiltYearorLater(int year)
        {
            return cars.Where(x=> x.buildYear >= year).Count();
        }
        public double AvgPriceByHp(int minHp)
        {
            return cars.Where(x=> x.HP >= minHp).Average(x=> x.price);
        }
        public string KJDFJSN(int minPrice)
        {
            return cars.Where(x=> x.price > minPrice).OrderBy(x=> x.price).Select(x=> x.type).First().ToString();

        }
        public string StrongerHpBYyear(int year)
        {
            return cars.Where(x=> x.buildYear > year).OrderBy(x=> x.HP).Select(x=> x.type).First();
        }
        public List<string> BelowAvgPrice()
        {
            return cars.Where(x => x.price < cars.Average(x => x.price)).OrderByDescending(x=> x.price).Select(x=> x.type).ToList();
        }
        public List<string> Brands()
        {
            return cars.Select(x=> x.brand).Distinct().ToList();
        }
        public int BrandsCount()
        {
            return cars.Select(x => x.brand).Distinct().Count();
        }
        public Dictionary<string, int> GroupByType()
        {
            return cars.GroupBy(x => x.brand).ToDictionary(x => x.Key, y => y.Count());
        }

    }
}
