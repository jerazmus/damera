using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DameraAPI.DameraSOA.TokenNS.Model;
using DameraAPI.DameraSOA.UserNS.Model;

namespace DameraAPI.DameraSOA.TokenNS.Service
{
    public interface ITokenQueryHandler
    {
        Task<IEnumerable<Token>> Get();
        Task<Token> Get(int id);
        Task<User> Verify(String userToken);
    }
}
