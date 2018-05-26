using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass5
{
    //5Q1
    class FloatingRateBond : Bond
    {
        private static Random random = new Random(); 
        public override double Rate { get => random.Next(1,10); set => base.Rate = value; }
        public FloatingRateBond(string iD, double price, int quantity, int years) : base(iD, price, quantity, years, random.Next(1, 10))
        {
        }
    }
}
