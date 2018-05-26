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
        public event Program.SplitStock SplitStockEvent;

        public void Subscribe()
        {
            SplitStockEvent += EventHandler;
        }

        public void EventHandler(string str)
        {
            Console.WriteLine(str);
        }

        //3Q6
        public List<Product> CollectionOfStocks = new List<Product>();
        
        public void AddToPortfolio(Product stock)
        {
            CollectionOfStocks.Add(stock);
        }

        public double GetNotional()
        {
            double total = 0;

            foreach (Product stock in CollectionOfStocks)
            {
                total += stock.GetNotional();
            }

            return total;
        }

        internal void Call(string str)
        {
            SplitStockEvent(str);
        }
    }
}
