using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Q1.

namespace Ass2
{
    class Stock
    {
        public double Price { get; set; }
        public int Quantity { get; set; }
        public string ID { get; set; }

        public Stock(string iD, double price, int quantity)
        {
            ID = iD;
            Price = price;
            Quantity = quantity;
        }

        public double GetNotional()
        {
            return Price * Quantity;
        }

        public void SplitStocks()
        {
            Price /= 2;
            Quantity *= 2;
        }

        public override string ToString()
        {
            return String.Format("ID : {0}, Price : {1}, Quantity : {2}",ID,Price,Quantity);
        }

    }
}
