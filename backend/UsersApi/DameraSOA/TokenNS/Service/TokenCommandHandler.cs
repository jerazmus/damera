using System;
using System.Collections.Generic;
using System.Security.Authentication;
using System.Threading.Tasks;
using UsersApi.DameraSOA.TokenNS.Model;
using UsersApi.DameraSOA.UserNS.Model;

namespace UsersApi.DameraSOA.TokenNS.Service
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
            //todo walidacja
            if (_userRepository.PasswordSignInAsync(user.Email, user.Password).Result)
            {
                User User = _userRepository.FindOne(user.Email).Result;
                Token token = await _tokenRepository.Generate(User.ID);
                var newToken = await _tokenRepository.Save(token);
                await _userRepository.GenerateCookies(User.Email, token.UserToken);

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
            await _userRepository.DeleteCookies();
        }
        
    }
}
