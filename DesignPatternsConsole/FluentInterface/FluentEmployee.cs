using System;

namespace DesignPatternsConsole.FluentInterface
{
    public class FluentEmployee
    {
        private Employee employee = new Employee();
        public FluentEmployee NameOfTheEmployee(string FullName)
        {
            employee.FullName = FullName;
            return this;
        }
        public FluentEmployee Born(string DateOfBirth)
        {
            employee.DateOfBirth = Convert.ToDateTime(DateOfBirth);
            return this;
        }
        public FluentEmployee WorkingOn(string Department)
        {
            employee.Department = Department;
            return this;
        }
        public FluentEmployee StaysAt(string Address)
        {
            employee.Address = Address;
            return this;
        }

        public override string ToString()
        {
            return $"{employee.FullName} {employee.Address} {employee.DateOfBirth} {employee.Department}";
        }
    }


    public static class FluentInterfaceTester
    {
        public static void Run()
        {
            FluentEmployee obj = new FluentEmployee();
            obj.NameOfTheEmployee("Anurag Mohanty")
                .Born("10/10/1992")
                .WorkingOn("IT")
                .StaysAt("Mumbai-India");

            Console.WriteLine("Object created = " + obj.ToString());

        }
    }
}