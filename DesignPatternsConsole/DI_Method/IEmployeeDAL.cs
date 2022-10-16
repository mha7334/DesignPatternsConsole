using System.Collections.Generic;

namespace DesignPatternsConsole.DI_Method
{
    public interface IEmployeeDAL
    {
        List<Employee> SelectAllEmployees();
    }
}