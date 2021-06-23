namespace DesignPatternsConsole.Ioc
{
    public class GuestDataAccess : IGuestDataAccess
    {
        public Guest GetGuestDetails(int id)
        {
            // In real time get the employee details from db
            // but here we are hard coded the employee details
            Guest guest = new Guest()
            {
                ID = id,
                Name = "guest",
            };
            return guest;
        }
    }
}