namespace GrandBazar.Web.Controllers
{
    using GrandBazar.Web.Services;
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;

    public class UsersController : BaseController
    {
        private readonly IUsersService usersService;

        public UsersController(IUsersService usersService)
        {
            this.usersService = usersService;
        }

        public IActionResult Register()
        {
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(string firstName, string lastName, string email, string gender, string city, string country, string phoneNumber, string password, string confirmPassword)
        {
            await this.usersService.CreateUserAsync(firstName, lastName, email, gender, city, country, phoneNumber, password);

            return this.Redirect("/");
        }

        public IActionResult Login()
        {
            return this.View();
        }

        public IActionResult Logout()
        {
            this.SignOut();
            return this.Redirect("/");
        }
    }
}
