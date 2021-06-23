namespace DesignPatternsConsole.Ioc
{
    public interface IGuestDataAccess
    {
        Guest GetGuestDetails(int id);
    }
}