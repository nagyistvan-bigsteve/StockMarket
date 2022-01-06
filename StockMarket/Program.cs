using System;
using System.Threading.Tasks;

namespace StockMarket
{
    class Program
    {
        //Observer DP
        static void Main(string[] args)
        {
            var cipri = new Buyer("Cipri");
            var ana = new Buyer("Ana");
            var andreea = new Follower("Andreea");

            var agency = new CurrencyAgency();
            agency.AddNotify += cipri.OnCurrencyAdd;
            agency.ChangeNotify += cipri.OnCurrencyChange;
            agency.AddNotify += ana.OnCurrencyAdd;
            agency.ChangeNotify += ana.OnCurrencyChange;
            agency.AddNotify += andreea.OnCurrencyAdd;
            agency.ChangeNotify += andreea.OnCurrencyChange;

            var Currency1 = new Currency("BTC", 15.7);
            var Currency2 = new Currency("KLT", 952.04);

            agency.AddCurrency(Currency1);

            cipri.Buy(Currency1, 5);
            Console.WriteLine("---------------------");
            agency.AddCurrency(Currency2);
            Console.WriteLine("---------------------");
            andreea.UnSubChanges(false);
            agency.ChangeCurrency(Currency1,64157.8);
        }
    }
}
