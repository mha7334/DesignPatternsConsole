namespace DesignPatternsConsole.FactoryMethod
{
    public class MoneyBackFactory : CreditCardFactory
    {
        protected override ICreditCard MakeProduct()
        {
            return new MoneyBack();
        }
    }
}