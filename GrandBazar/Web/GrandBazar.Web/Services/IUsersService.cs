namespace GrandBazar.Web.Services
{
    using System.Threading.Tasks;

    public interface IUsersService
    {
        Task<string> CreateUserAsync(string firstName, string lastName, string email, string gender, string city, string country, string phoneNumber, string password);

       // bool IsEmailAvailable(string email);

        string GetUserId(string email, string password);
    }
}
