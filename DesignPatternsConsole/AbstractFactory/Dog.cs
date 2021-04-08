namespace DesignPatternsConsole.AbstractFactory
{
    public class Dog : IAnimal
    {
        public string Speak()
        {
            return "Bark bark";
        }
    }
}