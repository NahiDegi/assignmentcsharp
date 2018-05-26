using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ass5
{
    //3Q2.
    class Stock : Product
    {
        public Stock(string iD, double price, int quantity) : base(iD,price,quantity)
        {
            
        }

        public void SplitStocks()
        {
            Price /= 2;
            Quantity *= 2;
        }

        public override string ToString()
        {
            return "Stock";
        }

    }
}
