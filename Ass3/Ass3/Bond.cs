﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//3Q1.
namespace Ass3
{
    //3Q2.
    class Bond : Product
    {
        //3Q3.
        public int Years { get; set; }
        public double Rate { get; set; }

        public Bond(double price, int quantity, int years, double rate) :base(price,quantity)
        {
            Years = years;
            Rate = rate;
        }

        public double GetCoupon()
        {
            return Rate * 10;
        }
    }
}
