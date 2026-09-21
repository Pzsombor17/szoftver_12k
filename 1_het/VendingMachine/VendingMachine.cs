using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class VendingMachine
    {
        private List<Product> _products;
        private int _balance;
        private int _income;

        public int Balance { get; }
        public int Income { get; }

        private ProductCategory ParseCategory(string parameter)
        {
            if (parameter == "0")
            {
                return ProductCategory.Drink;
            }
        }
    }
}
