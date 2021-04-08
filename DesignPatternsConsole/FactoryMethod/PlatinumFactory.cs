namespace DesignPatternsConsole.FactoryMethod
{
    public class PlatinumFactory : CreditCardFactory
    {
        protected override ICreditCard MakeProduct()
        {
            return new Platinum();
        }
    }
}