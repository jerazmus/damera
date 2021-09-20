using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DameraAPI.DameraSOA.TokenNS.Model;
using DameraAPI.DameraSOA.UserNS.Model;

namespace DameraAPI.DameraSOA.TokenNS.Service
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

        public async Task<User> Verify(String userToken)
        {
            Token token = await _tokenRepository.FindOne(userToken);
            if(token != null)
            {
                User user = await _userRepository.FindOne(token.UserID);
                return user;
            }
            else
            {
                throw new NotImplementedException("Brak pasujacych tokenow");
            }
        }
    }
}
