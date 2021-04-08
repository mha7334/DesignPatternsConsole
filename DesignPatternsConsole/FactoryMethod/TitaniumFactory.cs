namespace DesignPatternsConsole.FactoryMethod
{
    public class TitaniumFactory : CreditCardFactory
    {
        protected override ICreditCard MakeProduct()
        {
            return new Titanium();
        }

      
    }
}