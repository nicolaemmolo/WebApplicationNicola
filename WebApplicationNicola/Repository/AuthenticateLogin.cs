using WebApplicationNicola.Models;

namespace WebApplicationNicola.Repository
{
    public class AuthenticateLogin : ILogin
    {
        public List<UserLogin> Users { get; set; } = new List<UserLogin>()
        {
            new UserLogin() { UserName = "nico", Password = "1234" },
            new UserLogin() { UserName = "mario", Password = "1234" },
            new UserLogin() { UserName = "luigi", Password = "1234" },
        };

        public bool AuthenticateUser(string username, string password)
        {
            var user = Users.FirstOrDefault(x => x.UserName == username && x.Password == password);

            if (Users.Contains(user)) return true;
            return false;
        }
    }
}
