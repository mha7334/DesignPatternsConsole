using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsConsole.FactoryMethod
{
    class MoneyBack : ICreditCard
    {
        public string GetCardType()
        {
            return "MoneyBack";
        }
        public int GetCreditLimit()
        {
            return 15000;
        }
        public int GetAnnualCharge()
        {
            return 500;
        }
    }
}
