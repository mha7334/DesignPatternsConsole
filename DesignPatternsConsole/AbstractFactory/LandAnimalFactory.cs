namespace DesignPatternsConsole.AbstractFactory
{
    public class LandAnimalFactory : AnimalFactory
    {
        public override IAnimal GetAnimal(AnimalType type)
        {
            if (type == AnimalType.Dog)
            {
                return new Dog();
            }
            else if (type == AnimalType.Cat)
            {
                return new Cat();
            }
            else if (type == AnimalType.Lion)
            {
                return new Lion();
            }
            else
                return null;
        }
    }
}