using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsersApi.DameraSOA.UserNS.Model
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> FindAll();
        Task<User> FindOne(int id);
        Task<User> FindOne(string email);
        Task GenerateCookies(string email, string userToken);
        Task DeleteCookies();
        Task<Boolean> UserExists(string email);
        Task<User> Save(User user);
        Task Update(User user);
        Task Delete(int id);
        Task<bool> PasswordSignInAsync(string email, string password);
    }
}