namespace DesignPatternsConsole.Ioc
{
    public class DataAccessFactory
    {
        public static IEmployeeDataAccess GetEmployeeDataAccessObj()
        {
            return new EmployeeDataAccess();
        }

        public static IGuestDataAccess GetGuestDataAccessObj()
        {
            return new GuestDataAccess();
        }
    }
}