namespace DesignPatternsConsole.Ioc
{
    public interface IEmployeeDataAccess
    {
        Employee GetEmployeeDetails(int id);
    }
}