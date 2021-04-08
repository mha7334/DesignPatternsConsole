using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsConsole.FactoryMethod
{
    public abstract class CreditCardFactory
    {
        protected abstract ICreditCard MakeProduct();

        public ICreditCard CreateProduct()
        {
            return this.MakeProduct();
        }

    }
}
