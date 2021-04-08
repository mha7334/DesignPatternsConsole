using System;

namespace DesignPatternsConsole.Ioc
{
    public class EmployeeBusinessLogic
    {
        IEmployeeDataAccess _EmployeeDataAccess;
        public EmployeeBusinessLogic(IEmployeeDataAccess dataAccess)
        {
            _EmployeeDataAccess = dataAccess;
        }
        public Employee GetEmployeeDetails(int id)
        {
            return _EmployeeDataAccess.GetEmployeeDetails(id);
        }
    }

    
}