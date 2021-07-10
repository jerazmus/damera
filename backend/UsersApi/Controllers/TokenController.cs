using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UsersApi.Models;
using UsersApi.Repositories;

namespace UsersApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        private readonly ITokenRepository _tokenRepository;
        private readonly TokenContext _context;
        private readonly UserContext _usercontext;

        public TokenController(ITokenRepository tokenRepository, TokenContext tokenContext, UserContext userContext)
        {
            _tokenRepository = tokenRepository;
            _context = tokenContext;
            _usercontext = userContext;
        }

        [HttpGet]
        public async Task<IEnumerable<Token>> GetTokens()
        {
            return await _tokenRepository.Get();
        }

        [HttpPost]
        public async Task<ActionResult<User>> Login([FromBody] User user)
        {
            List<string> emailList = await _usercontext.User.Select(user => user.Email).ToListAsync();
            if(emailList.Any(e => e == user.Email))
            {
                Random rand = new Random();
                string textToken = rand.Next(1,10)+user.Email+rand.Next(1,10)+DateTime.Now+rand.Next(1,10);
                var sha1 = new SHA1CryptoServiceProvider();
                var data = Encoding.ASCII.GetBytes(textToken);
                var userToken = sha1.ComputeHash(data);
                Token token = new Token();
                var User = await _usercontext.User.FirstOrDefaultAsync(u => u.Email == user.Email); ;
                //var hashedPassword = ASCIIEncoding.GetString(sha1data);
                token.UserID = User.UserID;
                token.UserToken = userToken.ToString();
                token.CreateDate = DateTime.Now;
                token.ExpirationDate = DateTime.Now.AddHours(6);
                var newToken = await _tokenRepository.Create(token);
                return CreatedAtAction(nameof(GetTokens), new {id = newToken.TokenID}, newToken);
            }
            else
            {
                //throw new BadRequest("Email is wrong!");
                return BadRequest("Email is wrong!");
            }
        }

    }
}
