using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsConsole.AbstractFactory
{
    public static class Tester
    {
        public static void Run()
        {
            IAnimal animal = null;
            AnimalFactory animalFactory = null;
            string speakSound = null;
            // Create the Sea Factory object by passing the factory type as Sea
            animalFactory = AnimalFactory.CreateAnimalFactory(AnimalFactoryType.Sea);
            Console.WriteLine("Animal Factory type : " + animalFactory.GetType().Name);
            Console.WriteLine();
            // Get Octopus Animal object by passing the animal type as Octopus
            animal = animalFactory.GetAnimal(AnimalType.Octopus);
            Console.WriteLine("Animal Type : " + animal.GetType().Name);
            speakSound = animal.Speak();
            Console.WriteLine(animal.GetType().Name + " Speak : " + speakSound);
            Console.WriteLine();
            Console.WriteLine("--------------------------");
            // Create Land Factory object by passing the factory type as Land
            animalFactory = AnimalFactory.CreateAnimalFactory(AnimalFactoryType.Land);
            Console.WriteLine("Animal Factory type : " + animalFactory.GetType().Name);
            Console.WriteLine();
            // Get Lion Animal object by passing the animal type as Lion
            animal = animalFactory.GetAnimal(AnimalType.Lion);
            Console.WriteLine("Animal Type : " + animal.GetType().Name);
            speakSound = animal.Speak();
            Console.WriteLine(animal.GetType().Name + " Speak : " + speakSound);
            Console.WriteLine();
            // Get Cat Animal object by passing the animal type as Cat
            animal = animalFactory.GetAnimal(AnimalType.Cat);
            Console.WriteLine("Animal Type : " + animal.GetType().Name);
            speakSound = animal.Speak();
            Console.WriteLine(animal.GetType().Name + " Speak : " + speakSound);
        }
    }
}
