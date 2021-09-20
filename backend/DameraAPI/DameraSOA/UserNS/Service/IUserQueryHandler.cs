using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DameraAPI.DameraSOA.UserNS.Model;

namespace DameraAPI.DameraSOA.UserNS.Service
{
    public interface IUserQueryHandler
    {
        Task<IEnumerable<User>> Get();
        Task<User> Get(int id);
    }
}
