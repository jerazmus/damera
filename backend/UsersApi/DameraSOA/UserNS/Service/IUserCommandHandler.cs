using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UsersApi.DameraSOA.UserNS.Model;

namespace UsersApi.DameraSOA.UserNS.Service
{
    public interface IUserCommandHandler
    {
        Task<User> Create(User user);
        Task Update(User user);
        Task Delete(int id);
    }
}
