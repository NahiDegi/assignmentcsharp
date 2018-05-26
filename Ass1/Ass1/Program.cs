using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Q1.

            List<int> OddNumbers = new List<int>();
            for(int i = 1; i < 100; i += 2)
            {
                OddNumbers.Add(i);
            }


            //Q2.
            foreach (int number in OddNumbers)
            {
                Console.Write(number + "\t");
            }



        }
    }
}
