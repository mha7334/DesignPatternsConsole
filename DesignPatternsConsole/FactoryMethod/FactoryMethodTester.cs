using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsConsole.FactoryMethod
{
    public static class FactoryMethodTester
    {
        public static void Run()
        {

            List<ICreditCard> cards = new List<ICreditCard>();

            cards.Add(new MoneyBack());
            cards.Add(new Platinum());
            cards.Add(new Titanium());

            foreach (var card in cards)
            {
                Console.WriteLine($"********* {card.GetCardType()} ******");
                Console.WriteLine("Card Type : " + card.GetCardType());
                Console.WriteLine("Credit Limit : " + card.GetCreditLimit());
                Console.WriteLine("Annual Charge :" + card.GetAnnualCharge());
            }

        }
    }
}
