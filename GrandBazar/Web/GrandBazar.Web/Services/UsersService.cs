namespace GrandBazar.Web.Services
{
    using System;
    using System.Linq;
    using System.Security.Cryptography;
    using System.Text;
    using System.Threading.Tasks;

    using GrandBazar.Data;
    using GrandBazar.Data.Common.Repositories;
    using GrandBazar.Data.Models;
    using GrandBazar.Data.Models.Enums;

    public class UsersService : IUsersService
    {
        private readonly IDeletableEntityRepository<ApplicationUser> usersRepository;

        public UsersService(IDeletableEntityRepository<ApplicationUser> usersRepository)
        {
            this.usersRepository = usersRepository;
        }

        public async Task<string> CreateUserAsync(string firstName, string lastName, string email, string gender, string city, string country, string phoneNumber, string password)
        {
            var user = new ApplicationUser
            {
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                CreatedOn = DateTime.UtcNow,
                Gender = Enum.Parse<Gender>(gender),
                PhoneNumber=phoneNumber,
                PasswordHash = this.ComputeHash(password),
            };

            await this.usersRepository.AddAsync(user);
            await this.usersRepository.SaveChangesAsync();

            return user.Id;
        }

        public ApplicationUser GetUser(string email, string password)
        {
            var user = this
                .usersRepository
                .All()
                .FirstOrDefault(x => x.Email == email && x.PasswordHash == ComputeHash(password));

            return user;
        }

        public string GetUserId(string email, string password)
        {
            var user = this
                .usersRepository
                .All()
                .FirstOrDefault(x => x.Email == email && x.PasswordHash == ComputeHash(password));

            return user?.Id;
        }

        // public bool IsEmailAvailable(string email)
        // {
        //     return !this.usersRepository;
        //}

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
