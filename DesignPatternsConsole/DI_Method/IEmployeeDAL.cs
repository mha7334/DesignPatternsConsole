using System.Collections.Generic;

namespace DesignPatternsConsole.DI_Prop
{
    public interface IEmployeeDAL
    {
        List<Employee> SelectAllEmployees();
    }
}