using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//3Q.1
namespace Ass4
{
    abstract class Product
    {
        public string ID { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public Product(string iD,double price, int quantity)
        {
            ID = iD;
            Price = price;
            Quantity = quantity;
        }

        public double GetNotional()
        {
            return Price * Quantity;
        }



    }
}
