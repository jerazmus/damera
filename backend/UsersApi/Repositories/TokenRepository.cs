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
        public async Task Delete(int id)
        {
            //var tokenToDelete = await _context.Token.FindAsync(user);
            var tokenToDelete = _context.Token.Where(b => b.UserID == id).FirstOrDefault();
            _context.Token.Remove(tokenToDelete);
            await _context.SaveChangesAsync();
        }




    }
}