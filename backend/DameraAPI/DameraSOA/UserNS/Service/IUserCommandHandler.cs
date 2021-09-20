using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DameraAPI.DameraSOA.UserNS.Model;

namespace DameraAPI.DameraSOA.UserNS.Service
{
    public interface IUserCommandHandler
    {
        Task<User> Create(User user);
        Task Update(User user);
        Task Delete(int id);
    }
}
