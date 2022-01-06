using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarket
{
    class CurrencyEventArgs
    {
        public CurrencyEventArgs(Currency currency)
        {
            Currency = currency;
        }

        public Currency Currency { get; private set; }
    }
}
