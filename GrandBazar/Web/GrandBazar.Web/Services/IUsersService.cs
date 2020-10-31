namespace GrandBazar.Web.Services
{
    using System.Threading.Tasks;

    public interface IUsersService
    {
        Task<string> CreateUser(string firstName, string lastName, string email, string address, string city, string country, string phoneNumber, string password);

        bool IsEmailAvailable(string email);

        string GetUserId(string firstName, string lastName, string password);
    }
}
