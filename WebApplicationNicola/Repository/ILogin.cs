using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplicationNicola.Models;

namespace WebApplicationNicola.Repository
{
    public interface ILogin
    {
        bool AuthenticateUser(string username, string password);
    }
}
