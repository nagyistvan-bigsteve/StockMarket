using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarket
{
    class Currency
    {
        public string _name;
        public double _value;

        public Currency(string name, double value)
        {
            _name = name;
            _value = value;
        }

        public Currency UpdateCurrency(double value)
        {
            _value = value;
            return this;
        }

        public string GetTitle() => $"{_name} -> {_value}";
    }
}
