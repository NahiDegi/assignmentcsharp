using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass2
{
    class Program
    {
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
            foreach (Stock stock in portfolio.CollectionOfStocks)
            {
                Console.WriteLine(stock.ToString());
            }


            //Q5
            Console.WriteLine("Total Notional of Portfolio : "+portfolio.GetNotional());


        }
    }
}
