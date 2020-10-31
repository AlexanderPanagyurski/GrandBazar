namespace GrandBazar.Web.Controllers
{
    using GrandBazar.Web.Services;
    using Microsoft.AspNetCore.Mvc;

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
        public IActionResult Register(string firstName, string lastName, string email, string address, string city, string country, string phoneNumber, string password, string confirmPassword)
        {
            this.usersService.CreateUser(firstName, lastName, email, address, city, country, phoneNumber, password);

            return this.Redirect("/");
        }

        public IActionResult Login()
        {
            return this.View();
        }
    }
}
