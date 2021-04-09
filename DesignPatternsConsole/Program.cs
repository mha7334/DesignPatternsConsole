using System;
using DesignPatternsConsole.Observer;

namespace DesignPatternsConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //1) click 'Show All Files in VisualStudio'
            //2) Then include Pattern/Principle's Folder (One at a time) in the project e.g.
            //AbstractFactory
            //Factory
            //FactoryMethod
            //Builder
            //Decorator
            //ChainOfResp
            //DI
            //FluentInterface
            //Prototype
            //Singleton
            //SingletonThreadSafe
            //Strategy
            //IoC
            //Facade
            //Adapter
            Tester.Run(null);

        }
    }
}

