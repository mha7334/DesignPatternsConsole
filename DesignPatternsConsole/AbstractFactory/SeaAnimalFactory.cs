namespace DesignPatternsConsole.AbstractFactory
{
    public class SeaAnimalFactory : AnimalFactory
    {
        public override IAnimal GetAnimal(AnimalType type)
        {
            if (type == AnimalType.Shark)
            {
                return new Shark();
            }
            else if (type == AnimalType.Octopus)
            {
                return new Octopus();
            }
            else
                return null;
        }
    }


    public enum AnimalType
    {
        Shark,
        Octopus,
        Dog,
        Cat,
        Lion
    }
}