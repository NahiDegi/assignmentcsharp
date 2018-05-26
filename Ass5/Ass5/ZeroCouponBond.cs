using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass5
{
    //5Q1
    class ZeroCouponBond : Bond 
    {
        public override double Rate { get => base.Rate; set => base.Rate = 0; }
        public ZeroCouponBond(string iD, double price, int quantity, int years) : base(iD, price, quantity, years, 0)
        {
        }

        //5Q6
        public override double GetCoupon()
        {
            if (Quantity == 0)
                throw new Exception("Quantity Can Never Be Zero!!!");
            return 0;
        }
    }
}
