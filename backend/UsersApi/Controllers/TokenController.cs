using System;
using System.Collections.Generic;
using System.Linq;
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

        public TokenController(ITokenRepository tokenRepository, TokenContext tokenContext)
        {
            _tokenRepository = tokenRepository;
            _context = tokenContext;
        }

        [HttpGet]
        public async Task<IEnumerable<Token>> GetTokens()
        {
            return await _tokenRepository.Get();
        }

    }
}
