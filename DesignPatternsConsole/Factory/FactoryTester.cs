using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsConsole.Factory
{
    public static class FactoryTester
    {
        public  static void  Run(CreditCardType cardType = CreditCardType.MoneyBack)
        {
            
            ICreditCard cardDetails = null;
            //Based of the CreditCard Type we are creating the
            //appropriate type instance using if else condition
            if (cardType == CreditCardType.MoneyBack)
            {
                cardDetails = new MoneyBack();
            }
            else if (cardType == CreditCardType.Titanium)
            {
                cardDetails = new Titanium();
            }
            else if (cardType == CreditCardType.Platinum)
            {
                cardDetails = new Platinum();
            }
            if (cardDetails != null)
            {
                Console.WriteLine("CardType : " + cardDetails.GetCardType());
                Console.WriteLine("CreditLimit : " + cardDetails.GetCreditLimit());
                Console.WriteLine("AnnualCharge :" + cardDetails.GetAnnualCharge());
            }
            else
            {
                Console.Write("Invalid Card Type");
            }
        }
       
    }

    public enum CreditCardType
    {
        Titanium,
        MoneyBack,
        Platinum
    }
}
