using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarket
{
    class Follower : Customer
    {
        public bool SubChanges = true;
        public bool SubNew = true;
        public Follower(string name) : base(name)
        {

        }

        public Follower UnSubNew(bool sub)
        {
            SubNew = sub;
            return this;
        }
        public Follower UnSubChanges(bool sub)
        {
            SubChanges = sub;
            return this;
        }

        public override void OnCurrencyAdd(object source, CurrencyEventArgs args)
        {
            if(SubNew)
            Console.WriteLine($"{Name} has been notified that the currency {args.Currency.GetTitle()} has been added");
        }

        public override void OnCurrencyChange(object source, CurrencyEventArgs args)
        {
            if (SubChanges)
                Console.WriteLine($"{Name} has been notified that the currency {args.Currency.GetTitle()} has been changed");
        }
    }
}
