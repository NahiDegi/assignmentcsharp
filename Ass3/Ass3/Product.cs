using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Q.1
namespace Ass3
{
    class Product
    {
        public double Price { get; set; }
        public int Quantity { get; set; }

        public Product(double price, int quantity)
        {
            Price = price;
            Quantity = quantity;
        }
    }
}
