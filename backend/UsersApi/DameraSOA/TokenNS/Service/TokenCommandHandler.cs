using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UsersApi.DameraSOA.TokenNS.Model;
using UsersApi.DameraSOA.UserNS.Model;
/*
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

        public Task Delete(int userID)
        {
            throw new NotImplementedException();
        }
        /*
        public Task<Token> Login(User user)
        {
            if (_userRepository.UserExists(user.Email).Result)
            {
                var User = await _usercontext.User.FirstOrDefaultAsync(u => u.Email == user.Email);

                Random rand = new Random();

                string textToken = rand.Next(1, 10) + user.Email + rand.Next(1, 10) + DateTime.Now + rand.Next(1, 10);
                var data = Encoding.ASCII.GetBytes(textToken);
                var sha1 = new SHA1CryptoServiceProvider();
                var userToken = sha1.ComputeHash(data);

                //var hashedPassword = ASCIIEncoding.GetString(sha1data);

                Token token = new Token();

                token.UserID = User.UserID;
                token.UserToken = Convert.ToBase64String(userToken);
                token.CreateDate = DateTime.Now;
                token.ExpirationDate = DateTime.Now.AddHours(6);

                await _tokenRepository.Delete(User.UserID);
                var newToken = await _tokenRepository.Create(token);

                CookieOptions cookieOptions = new CookieOptions();
                cookieOptions.Expires = DateTime.Now.AddHours(6);
                Response.Cookies.Append("DameraToken", Convert.ToBase64String(userToken), cookieOptions);
                Response.Cookies.Append("DameraLogin", user.Email, cookieOptions);

                return CreatedAtAction(nameof(GetTokens), new { id = newToken.TokenID }, newToken);
            }
            else
            {
                //throw new BadRequest("Email is wrong!");
                return BadRequest("Email is wrong!");
            }
        }
    }
}
*/