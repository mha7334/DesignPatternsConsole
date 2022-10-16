using System;

namespace DesignPatternsConsole.Prototype
{
    public static class PrototypeTester
    {
        public static void Run()
        {
            Employee emp1 = new Employee();
            emp1.Name = "Asif";
            emp1.Department = "Test";

            Employee emp2 = emp1.GetClone();

            emp2.Department = "Test1";


            Console.WriteLine(nameof(emp1) + emp1.Department);
            Console.WriteLine(nameof(emp2) + emp2.Department);


        }
    }
}
