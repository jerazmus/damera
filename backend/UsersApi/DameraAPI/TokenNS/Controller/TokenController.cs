using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UsersApi.DameraSOA.TokenNS.Model;
using UsersApi.DameraSOA.TokenNS.Service;
using UsersApi.DameraSOA.UserNS.Model;
using UsersApi.DameraSOA.UserNS.Service;

namespace UsersApi.DameraAPI.TokenNS.Controller
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        private readonly ITokenCommandHandler _tokenCommandHandler;
        private readonly ITokenQueryHandler _tokenQueryHandler;

        public TokenController(ITokenCommandHandler tokenCommandHandler, ITokenQueryHandler tokenQueryHandler)
        {
            _tokenCommandHandler = tokenCommandHandler;
            _tokenQueryHandler = tokenQueryHandler;
        }

        [HttpGet]
        public async Task<IEnumerable<Token>> GetTokens()
        {
            return await _tokenQueryHandler.Get();
        }
        
        [HttpPost]
        public async Task<ActionResult<Token>> Login([FromBody] User user)
        {
            return await _tokenCommandHandler.Login(user);
        }

        [HttpGet]
        public async Task<bool> Verify()
        {
            return await _tokenQueryHandler.Verify();
        }
        
        [HttpDelete("{id}")]
        public async Task Logout(int id)
        {
            await _tokenCommandHandler.Delete(id);
        }

    }
}
