using System.Threading.Tasks;
using DatingApp.API.Models;

namespace DatingApp.API.Data
{
    public interface IAuthRepository
    {
         Task<User> Register(User user, string password);  // returns a user

         Task<User> Login(string username, string password);  // returns a user

         Task<bool> UserExists(string username);  // returns a boolean
    }
}