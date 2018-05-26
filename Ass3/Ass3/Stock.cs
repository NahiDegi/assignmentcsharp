﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ass3
{
    //Q2.
    class Stock : Product
    {
        public string ID { get; set; }

        public Stock(string iD, double price, int quantity) : base(price,quantity)
        {
            ID = iD;
            
        }

        public double GetNotional()
        {
            return Price * Quantity;
        }

        public void SplitStocks()
        {
            Price /= 2;
            Quantity *= 2;
        }

        public override string ToString()
        {
            return String.Format("ID : {0}, Price : {1}, Quantity : {2}",ID,Price,Quantity);
        }

    }
}