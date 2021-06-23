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

    public class GuestBusinessLogic
    {
        readonly IGuestDataAccess _guestDataAccess;
        public GuestBusinessLogic(IGuestDataAccess dataAccess)
        {
            _guestDataAccess = dataAccess;
        }
        public Guest GetGuestDetails(int id)
        {
            return _guestDataAccess.GetGuestDetails(id);
        }
    }

}