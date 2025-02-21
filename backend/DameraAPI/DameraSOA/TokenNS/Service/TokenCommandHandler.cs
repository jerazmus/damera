﻿using System;
using System.Collections.Generic;
using System.Security.Authentication;
using System.Threading.Tasks;
using DameraAPI.DameraSOA.TokenNS.Model;
using DameraAPI.DameraSOA.UserNS.Model;

namespace DameraAPI.DameraSOA.TokenNS.Service
{
    public class TokenCommandHandler : ITokenCommandHandler
    {
        private readonly ITokenRepository _tokenRepository;
        private readonly IUserRepository _userRepository;

        public TokenCommandHandler(ITokenRepository tokenRepository, IUserRepository userRepository)
        {
            _tokenRepository = tokenRepository;
            _userRepository = userRepository;
           
        }

        public Task<Token> Create(Token token)
        {
            throw new NotImplementedException();
        }

        public async Task<Token> Login(User user)
        {
            if (_userRepository.PasswordSignInAsync(user.Email, user.Password).Result)
            {
                User User = _userRepository.FindOne(user.Email).Result;
                Token token = await _tokenRepository.Generate(User.ID);
                var newToken = await _tokenRepository.Save(token);

                return newToken;
            }
            else
            {
                throw new AuthenticationException("Incorrect credentials!");
            }
        }

        public async Task Delete(int userID)
        {
            var User = await _userRepository.FindOne(userID);
            await _tokenRepository.Delete(User.ID);
        }
        
    }
}
