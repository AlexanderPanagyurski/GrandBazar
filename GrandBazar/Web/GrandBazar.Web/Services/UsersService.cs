namespace GrandBazar.Web.Services
{
    using System.Linq;
    using System.Security.Cryptography;
    using System.Text;
    using System.Threading.Tasks;

    using GrandBazar.Data;
    using GrandBazar.Data.Models;

    public class UsersService : IUsersService
    {
        private readonly ApplicationDbContext db;

        public UsersService(ApplicationDbContext db)
        {
            this.db = db;
        }

        public async Task<string> CreateUser(string firstName, string lastName, string email, string address, string city, string country, string phoneNumber, string password)
        {
            var user = new ApplicationUser
            {
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                PasswordHash = this.ComputeHash(password),
            };

            await this.db.Users.AddAsync(user);
            await this.db.SaveChangesAsync();

            return user.Id;
        }

        public string GetUserId(string firstName, string lastName, string password)
        {
            var user = this.db
                .Users
                .FirstOrDefault(x => x.FirstName == firstName && x.LastName == lastName && x.PasswordHash == this.ComputeHash(password));
            return user?.Id;
        }

        public bool IsEmailAvailable(string email)
        {
            return !this.db.Users.Any(x => x.Email == email);
        }

        private string ComputeHash(string input)
        {
            var bytes = Encoding.UTF8.GetBytes(input);
            using (var hash = SHA512.Create())
            {
                var hashedInputBytes = hash.ComputeHash(bytes);

                // Convert to text
                // StringBuilder Capacity is 128, because 512 bits / 8 bits in byte * 2 symbols for byte
                var hashedInputStringBuilder = new StringBuilder(128);
                foreach (var b in hashedInputBytes)
                {
                    hashedInputStringBuilder.Append(b.ToString("X2"));
                }

                return hashedInputStringBuilder.ToString();
            }
        }
    }
}
