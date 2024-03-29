﻿using System;

namespace DesignPatternsConsole.Template
{
    class Tester
    {
        public static void Run(string[] args)
        {
            Console.WriteLine("Nescafe Coffee Preparation\n");
            CoffeeTemplate coffee = new NescafeCoffee();
            coffee.PrepareCoffee();
            Console.WriteLine();
            Console.WriteLine("Bru coffee preparation\n");
            coffee = new BruCoffee();
            coffee.PrepareCoffee();
            Console.Read();
        }
    }
}