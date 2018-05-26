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
            printNumbers(OddNumbers);

            Console.WriteLine("");

            //Q3.
            Console.Write("Enter the number to be checked for primality : ");
            if (isPrime(int.Parse(Console.ReadLine())))
            {
                Console.WriteLine("Number is prime.\n");
            }
            else
            {
                Console.WriteLine("Number is not prime.\n");
            }

            //Q4.

            List<int> OddPrimeNumbers = new List<int>();
            List<int> OddNonPrimeNumbers = new List<int>();

            foreach (int number in OddNumbers)
            {
                if (isPrime(number))
                {
                    OddPrimeNumbers.Add(number);
                }
                else
                {
                    OddNonPrimeNumbers.Add(number);
                }
            }

            //Q5.

            //OddPrime

            Console.Write("Odd Prime NUmbers less than 100 : ");
            printNumbers(OddPrimeNumbers);

            Console.Write("Odd Non Prime NUmbers less than 100 : ");
            printNumbers(OddNonPrimeNumbers);
        }

        private static void printNumbers(List<int> numbers)
        {
            foreach (int number in numbers)
            {
                Console.Write(number + "\t");
            }

            Console.WriteLine("\n");

        }

        private static bool isPrime(int v)
        {
            for (int i = 2; i <= Math.Sqrt(v); i++)
            {
                if (v % i == 0)
                    return false;
            }
            return true;
        }
    }
}
