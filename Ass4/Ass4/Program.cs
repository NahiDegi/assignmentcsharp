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
            //Q3
            Portfolio portfolio = new Portfolio();
            Random random = new Random();

            //3Q8
            portfolio.Subscribe();


            //3Q7
            for (int i = 0; i < 5; i++)
            {
                portfolio.AddToPortfolio(new Stock("StockID" + i,
                    random.Next(100, 200),
                    random.Next(1, 10)));
            }

            for (int i = 0; i < 5; i++)
            {
                portfolio.AddToPortfolio(new Bond("BondID" + i,
                    random.Next(100, 200),
                    random.Next(1, 10),
                    random.Next(1,10),
                    random.Next(1,5)));
            }

            //Testing products use ctrl + k,u to uncomment
            //foreach (Product stock in portfolio.CollectionOfStocks)
            //{
            //    Console.WriteLine(stock.ToString());
            //}

            //3Q9
            Console.WriteLine("Total Notional of Portfolio : " + portfolio.GetNotional() + "\n");

            //3Q10
            foreach (Product product in portfolio.CollectionOfStocks)
            {
                if (product.ToString().Equals("Stock"))
                {
                    Console.WriteLine("Stock ID : {0}, Quantity : {1}, Price : {2}", 
                        product.ID, 
                        product.Quantity, 
                        product.Price);
                }
            }


            //3Q11
            portfolio.Call("Chill");

            //3Q13
            foreach (Product product in portfolio.CollectionOfStocks)
            {
                if (product.ToString().Equals("Bond"))
                {
                    Console.WriteLine("Bond coupon : {0}",((Bond)product).GetCoupon());
                }
            }

            //printProduct(portfolio.CollectionOfStocks.ToList());

            //3Q14
            printProduct(portfolio.CollectionOfStocks.ToList().Where(r => r.GetNotional()>1000));
        }

        private static void printProduct(IEnumerable<Product> enumerable)
        {
            foreach (Product product in enumerable)
            {
                Console.WriteLine("ID : {0}, Notional : {1}",product.ID,product.GetNotional());
            }
        }
    }
}
