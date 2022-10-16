namespace DesignPatternsConsole.Prototype
{
    public class Employee
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public Address Address { get; set; }


        public Employee GetClone()
        {
            var emp = (Employee)this.MemberwiseClone();
            emp.Address = Address.GetClone();
            return emp;
        }
    }
}
