using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UsersApi.DameraSOA.TokenNS.Model;
using UsersApi.DameraSOA.UserNS.Model;

namespace UsersApi.DameraSOA.TokenNS.Service
{
    public class TokenQueryHandler : ITokenQueryHandler
    {
        private readonly ITokenRepository _tokenRepository;
        private readonly IUserRepository _userRepository;

        public TokenQueryHandler(ITokenRepository tokenRepository, IUserRepository userRepository)
        {
            _tokenRepository = tokenRepository;
            _userRepository = userRepository;
        }

        public async Task<IEnumerable<Token>> Get()
        {
            return await _tokenRepository.Find();
        }

        public Task<Token> Get(int userID)
        {
            throw new NotImplementedException();
        }

        public async Task<User> Verify()
        {
            if(await _tokenRepository.CheckCookies())
            {
                string cookieLogin, cookieToken;
                (cookieLogin, cookieToken) = await _tokenRepository.GetCookies();
                User user = await _userRepository.FindOne(cookieLogin);
                Token token = await _tokenRepository.FindOne(user.ID);
                if (token.UserToken == cookieToken)
                {
                    return user;
                }
                else
                {
                    throw new NotImplementedException("Brak pasujacych tokenow");
                }
            }
            else
            {
                throw new NotImplementedException("Brak istniejacego tokenu");
            }     
        }
    }
}
