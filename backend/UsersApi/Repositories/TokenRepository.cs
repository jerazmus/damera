using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UsersApi.Models;
using UsersApi.Repositories;
using Microsoft.EntityFrameworkCore;


namespace UsersApi.Repositories
{
    public class TokenRepository : ITokenRepository
    {
        private readonly TokenContext _context;

        public TokenRepository(TokenContext context)
        {
            _context = context;
        }
        
        public async Task<Token> Create(Token token)
        {
            _context.Token.Add(token);
            await _context.SaveChangesAsync();
            return token;
        }
        public async Task<IEnumerable<Token>> Get()
        {
            return await _context.Token.ToListAsync();
        }

        public async Task<Token> Get(int userID)
        {
            return await _context.Token.Where(b => b.UserID == userID).FirstOrDefaultAsync();
        }

        public async Task Delete(int userID)
        {
            var tokenToDelete = _context.Token.Where(b => b.UserID == userID).FirstOrDefault();
            _context.Token.Remove(tokenToDelete);
            await _context.SaveChangesAsync();
        }




    }
}