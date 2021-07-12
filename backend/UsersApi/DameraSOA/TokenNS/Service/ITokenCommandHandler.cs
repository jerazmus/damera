using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UsersApi.DameraSOA.TokenNS.Model;
using UsersApi.DameraSOA.UserNS.Model;

namespace UsersApi.DameraSOA.TokenNS.Service
{
    public interface ITokenCommandHandler
    {
        Task<Token> Create(Token token);
        Task Delete(int userID);
        Task<Token> Login(User user);
    }
}
