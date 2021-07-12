using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace UsersApi.DameraSOA.TokenNS.Model
{
    public class TokenRepository : ITokenRepository
    {
        private readonly TokenContext _context;

        public TokenRepository(TokenContext context)
        {
            _context = context;
        }
        
        public async Task<Token> Save(Token token)
        {
            _context.Token.Add(token);
            await _context.SaveChangesAsync();
            return token;
        }

        public async Task<IEnumerable<Token>> Find()
        {
            return await _context.Token.ToListAsync();
        }

        public async Task<Token> FindOne(int userID)
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