using DesignPatternsConsole.Mediator;
using System;
using System.Data;

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
            //Tester.Run();


            Tester.Run(null);



        }
        private static void ReadSingleRow(IDataRecord record)
        {
            Console.WriteLine(String.Format("{0}, {1}", record[0], record[1]));
        }
    }
}

