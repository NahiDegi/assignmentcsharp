using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Q1.
namespace Ass3
{
    //Q2.
    class Bond : Product
    {
        //Q3.
        public int Years { get; set; }
        public double Rate { get; set; }

        public Bond(double price, int quantity, int years, double rate) :base(price,quantity)
        {
            Years = years;
            Rate = rate;
        }
    }
}
