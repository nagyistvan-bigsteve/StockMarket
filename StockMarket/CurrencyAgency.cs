using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarket
{
    class CurrencyAgency
    {
        public event EventHandler<CurrencyEventArgs> AddNotify;
        public event EventHandler<CurrencyEventArgs> ChangeNotify;

        public void AddCurrency(Currency currency)
        {
            if (AddNotify != null)
            {
                AddNotify(this, new CurrencyEventArgs(currency));
            }
        }
        public void ChangeCurrency(Currency currency, double value)
        {
            if (ChangeNotify != null)
            {
                ChangeNotify(this, new CurrencyEventArgs(currency.UpdateCurrency(value)));
            }
        }
    }
}
