using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace étlap
{
    public class MenuItem
    {
        public string Name { get; set; }
        public string Category { get; set; }
        private int _price { get; set; }
        public static int Count;
        public int Price
        {
            get { return _price; }
            set
            {
                _price = value < 0 ? 0 : value;
            }
        }
        public bool IsAviable { get; set; }

        public void SellOut()
        {
            IsAviable = false;
        }
        public void Restock()
        {
            IsAviable = true;
        }
        public MenuItem(string name, string category, int price)
        {
            Name = name;
            Category = category;
            Price = price;
            IsAviable = true;
            Count++;
        }
        public string GetDescription()
        {
            return $"{Name},{Category},{Price}";
        }

    }
}
