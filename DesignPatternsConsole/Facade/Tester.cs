using System;

namespace DesignPatternsConsole.Facade
{
    public class Tester
    {
        public static void Run(string[] args = null)
        {
            Order order = new Order();
            order.PlaceOrder();
        }

    }
}