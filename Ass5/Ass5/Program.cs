using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass5
{
    class Program
    {
        public delegate void SplitStock(string arg);

        static void Main(string[] args)
        {
            Portfolio portfolio = new Portfolio();
            Random random = new Random();

            ZeroCouponBond zeroCouponBond = new ZeroCouponBond("Zero", 45, 6, 6);
            FloatingRateBond floatingRateBond = new FloatingRateBond("Float", 45, 6, 6);

            //5Q2
            Bond bond1 = zeroCouponBond;
            Bond bond2 = floatingRateBond;
            Console.WriteLine("With Bond\nZero Coupon Bond : {0} \nFloating Coupon Bond : {1}", bond1.GetCoupon(), bond2.GetCoupon());

            //5Q3

            Product product1 = zeroCouponBond;
            Product product2 = floatingRateBond;
            Console.WriteLine("With Product\nZero Coupon Bond : {0} \nFloating Coupon Bond : {1}", ((Bond)product1).GetCoupon(), ((Bond)product2).GetCoupon());

        }
    }
}
