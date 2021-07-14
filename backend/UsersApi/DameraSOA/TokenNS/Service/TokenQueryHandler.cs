using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UsersApi.DameraSOA.TokenNS.Model;

namespace UsersApi.DameraSOA.TokenNS.Service
{
    public class TokenQueryHandler : ITokenQueryHandler
    {
        private readonly ITokenRepository _tokenRepository;

        public TokenQueryHandler(ITokenRepository tokenRepository)
        {
            _tokenRepository = tokenRepository;
        }

        public async Task<IEnumerable<Token>> Get()
        {
            return await _tokenRepository.Find();
        }

        public Task<Token> Get(int userID)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Verify()
        {
            if(await _tokenRepository.CheckCookies())
            {
                throw new NotImplementedException("true");
            }
            else
            {
                throw new NotImplementedException("false");
            }     
        }
    }
}
