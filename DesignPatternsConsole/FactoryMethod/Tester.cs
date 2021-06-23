using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsConsole.FactoryMethod
{
    public static class Tester
    {
        public static void Run()
        {

            List<ICreditCard> cards = new List<ICreditCard>();

          

            CreditCardFactory factory = new MoneyBackFactory();
            var moneyBack = factory.CreateProduct();

            factory = new PlatinumFactory();
            var platinum = factory.CreateProduct();

            factory = new TitaniumFactory();
            var titanium = factory.CreateProduct();



            cards.Add(moneyBack);
            cards.Add(platinum);
            cards.Add(titanium);
            

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
