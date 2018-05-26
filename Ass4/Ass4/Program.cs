using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass4
{
    class Program
    {
        //3Q4.
        public delegate void SplitStock(string arg);

        static void Main(string[] args)
        {
            //4Q1

            Stock s1 = new Stock("Rel", 56, 4);
            Stock s2 = new Stock("Rel", 56, 4);

            //4Q2

            Console.WriteLine(s1.Equals(s2));

        }
    }
}
