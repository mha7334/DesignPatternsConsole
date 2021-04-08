using System;

namespace DesignPatternsConsole.Facade
{
    public class Tester
    {
        public static void Run(string[] args)
        {
            Order order = new Order();
            order.PlaceOrder();
        }

    }
}