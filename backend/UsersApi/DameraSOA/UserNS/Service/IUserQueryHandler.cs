using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UsersApi.DameraSOA.UserNS.Model;

namespace UsersApi.DameraSOA.UserNS.Service
{
    public interface IUserQueryHandler
    {
        Task<IEnumerable<User>> Get();
        Task<User> Get(int id);
    }
}
