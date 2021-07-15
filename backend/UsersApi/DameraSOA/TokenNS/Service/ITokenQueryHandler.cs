using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UsersApi.DameraSOA.TokenNS.Model;

namespace UsersApi.DameraSOA.TokenNS.Service
{
    public interface ITokenQueryHandler
    {
        Task<IEnumerable<Token>> Get();
        Task<Token> Get(int userID);
        Task<bool> Verify();
    }
}
