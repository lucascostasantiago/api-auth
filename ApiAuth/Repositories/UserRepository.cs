using ApiAuth.Models;

namespace ApiAuth.Repositories
{
    public static class UserRepository
    {
        public static User Get(string username, string password)
        {
            var users = new List<User>
            {
                new() { Id = 1, Username = "lucas", Password = "lucas", Role = "manager" },
                new() { Id = 1, Username = "santiago", Password = "santiago", Role = "employee" },
            };
            return users.FirstOrDefault(x => x.Username == username && x.Password == password);
        }
    }
}
