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

            //4Q4
            Portfolio portfolio = new Portfolio();
            Random random = new Random();

            for (int i = 0; i < 5; i++)
            {
                portfolio.AddToPortfolio(new Stock("StockID" + i,
                    random.Next(100, 200),
                    random.Next(1, 10)));
            }

            printStocks(portfolio.CollectionOfStocks.ToList().OrderByDescending(a => a.GetNotional()));

        }

        private static void printStocks(IOrderedEnumerable<Product> orderedEnumerable)
        {
            foreach (Product product in orderedEnumerable)
            {
                Console.WriteLine("ID : {0}, Notional : {1}", product.ID, product.GetNotional());
            }
        }
    }
}
