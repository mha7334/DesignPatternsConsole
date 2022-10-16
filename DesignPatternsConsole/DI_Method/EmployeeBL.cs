using System.Collections.Generic;

namespace DesignPatternsConsole.DI_Method
{
    public class EmployeeBL
    {
        public IEmployeeDAL employeeDAL;

        public List<Employee> GetAllEmployees(IEmployeeDAL _employeeDAL)
        {
            employeeDAL = _employeeDAL;
            return employeeDAL.SelectAllEmployees();
        }
    }
}