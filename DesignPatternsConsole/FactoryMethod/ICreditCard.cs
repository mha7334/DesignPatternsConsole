using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsConsole.FactoryMethod
{
    public interface ICreditCard
    {
        string GetCardType();
        int GetCreditLimit();
        int GetAnnualCharge();
    }
}
