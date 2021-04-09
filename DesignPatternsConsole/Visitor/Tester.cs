using System;

namespace DesignPatternsConsole.Visitor
{
    public class Tester
    {
        public static void Run(string[] args)
        {
            School school = new School();
            var visitor1 = new Doctor("James");
            school.PerformOperation(visitor1);
            Console.WriteLine();
            var visitor2 = new Salesman("John");
            school.PerformOperation(visitor2);
            Console.Read();
        }
    }
}