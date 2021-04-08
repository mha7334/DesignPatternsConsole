namespace DesignPatternsConsole.AbstractFactory
{
    public abstract class AnimalFactory
    {
        public abstract IAnimal GetAnimal(AnimalType type);
        public static AnimalFactory CreateAnimalFactory(AnimalFactoryType animalFactoryType
        )
        {
            if (animalFactoryType == AnimalFactoryType.Sea)
                return new SeaAnimalFactory();
            else
                return new LandAnimalFactory();
        }
    }


    public enum AnimalFactoryType
    {
        Sea,
        Land
    }
}