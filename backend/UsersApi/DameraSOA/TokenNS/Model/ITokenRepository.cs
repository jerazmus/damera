using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsersApi.DameraSOA.TokenNS.Model
{
    public interface ITokenRepository
    {
        Task<IEnumerable<Token>> Find();
        Task<Token> FindOne(int userID);
        Task<Token> Save(Token token);
        Task Delete(int userID);
    }
}