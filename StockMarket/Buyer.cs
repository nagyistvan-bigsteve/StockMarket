using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarket
{
    class Buyer : Customer
    {
        private Dictionary<Currency, int> amount = new Dictionary<Currency, int>();

        public Buyer(string name) : base(name) 
        {

        }
        public Buyer Buy(Currency currency, int value)
        {
            amount.Add(currency, value);
            return this;
        }

        public override void OnCurrencyAdd(object source, CurrencyEventArgs args)
        {
            Console.WriteLine($"{Name} has been notified that the currency {args.Currency.GetTitle()} has been added");
        }

        public override void OnCurrencyChange(object source, CurrencyEventArgs args)
        {
            Console.WriteLine($"{Name} has been notified that the currency {args.Currency.GetTitle()} has been changed");
            
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            string result = $"{Name} has: \n";
            foreach(KeyValuePair<Currency,int> myCurrency in amount)
            {
                result += $"{myCurrency.Key._name} -> {myCurrency.Key._value * myCurrency.Value}";
            }
            return result;
        }
    }
}
