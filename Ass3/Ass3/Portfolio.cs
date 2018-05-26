using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Q2.
namespace Ass3
{
    class Portfolio
    {
        //3Q5.
        public event Program.SplitStock SplitStock;

        public List<Stock> CollectionOfStocks = new List<Stock>();
        
        public void AddToPortfolio(Stock stock)
        {
            CollectionOfStocks.Add(stock);
        }

        public double GetNotional()
        {
            double total = 0;

            foreach (Stock stock in CollectionOfStocks)
            {
                total += stock.GetNotional();
            }

            return total;
        }
    }
}
