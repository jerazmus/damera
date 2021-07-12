using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UsersApi.Models;

namespace UsersApi.Repositories
{
    public interface ITokenRepository
    {
        Task<Token> Create(Token token);
        Task<IEnumerable<Token>> Get();
        Task<Token> Get(int userID);
        Task Delete(int userID);
    }
}