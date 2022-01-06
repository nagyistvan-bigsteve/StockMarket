using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarket
{
    abstract class Customer
    {
        public string Name;

        public Customer(string name)
        {
            Name = name;
        }

        public abstract void OnCurrencyAdd(object source, CurrencyEventArgs args);
        public abstract void OnCurrencyChange(object source, CurrencyEventArgs args);
    }
}
