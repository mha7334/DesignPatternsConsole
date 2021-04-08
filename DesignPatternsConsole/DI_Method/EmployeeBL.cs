using System;
using System.Collections.Generic;

namespace DesignPatternsConsole.DI_Prop
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