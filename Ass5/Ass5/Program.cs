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

            

            //5Q2
            Bond bond1 = new ZeroCouponBond("Zero", random.Next(1, 100), random.Next(0, 10), random.Next(1, 10));
            Bond bond2 = new FloatingRateBond("Float", random.Next(1, 100), random.Next(0, 10), random.Next(1, 10));
            Console.WriteLine("With Bond\nZero Coupon Bond : {0} \nFloating Coupon Bond : {1}", bond1.GetCoupon(), bond2.GetCoupon());

            //5Q3

            Product product1 = new ZeroCouponBond("Zero", random.Next(1, 100), random.Next(0, 10), random.Next(1, 10));
            Product product2 = new FloatingRateBond("Float", random.Next(1, 100), random.Next(0, 10), random.Next(1, 10));
            Console.WriteLine("With Product\nZero Coupon Bond : {0} \nFloating Coupon Bond : {1}", ((Bond)product1).GetCoupon(), ((Bond)product2).GetCoupon());

            //5Q4
            ZeroCouponBond zeroCouponBond = new ZeroCouponBond("Zero", random.Next(1, 100), random.Next(0, 10), random.Next(1, 10));
            FloatingRateBond floatingRateBond = new FloatingRateBond("Float", random.Next(1, 100), random.Next(0, 10), random.Next(1, 10));
            Console.WriteLine("Individual\nZero Coupon Bond : {0} \nFloating Coupon Bond : {1}", zeroCouponBond.GetCoupon(), floatingRateBond.GetCoupon());
        }
    }
}
