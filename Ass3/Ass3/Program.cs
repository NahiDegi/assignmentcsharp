using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass3
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


            //Q4
            for (int i = 0; i < 5; i++)
            {
                portfolio.AddToPortfolio(new Stock("ID" + i,
                    random.Next(100, 200),
                    random.Next(1, 10)));
            }

            //Testing stocks use ctrl + k,u to uncomment
            //foreach (Stock stock in portfolio.CollectionOfStocks)
            //{
            //    Console.WriteLine(stock.ToString());
            //}


            //Q5,8
            Console.WriteLine("Total Notional of Portfolio : "+portfolio.GetNotional()+"\n");

            //Q6.
            foreach (Stock stock in portfolio.CollectionOfStocks)
            {
                if (stock.GetNotional() > 1000)
                {
                    Console.WriteLine("ID : {0}, Notional : {1}", stock.ID, stock.GetNotional());
                }
            }
            Console.WriteLine("");

            //Q7.
            oddSplit(portfolio);




        }

        private static void oddSplit(Portfolio portfolio)
        {
            for (int i = 0; i < portfolio.CollectionOfStocks.Count; i++)
            {
                Stock stock = portfolio.CollectionOfStocks[i];
                if ((stock.Quantity & 1) == 1)
                {
                    Console.WriteLine("Before Split -- ID : {0} , Quantity : {1} , Price : {2}",
                        stock.ID,
                        stock.Quantity,
                        stock.Price);

                    stock.SplitStocks();
                    portfolio.CollectionOfStocks[i] = stock;

                    Console.WriteLine("After Split -- ID : {0} , Quantity : {1} , Price : {2}",
                        stock.ID,
                        stock.Quantity,
                        stock.Price);

                    Console.WriteLine("");
                }
            }
        }
    }
}
