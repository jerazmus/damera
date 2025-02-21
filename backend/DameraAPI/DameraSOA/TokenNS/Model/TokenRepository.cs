using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;


namespace DameraAPI.DameraSOA.TokenNS.Model
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
            var updateToken = _context.Token.Where(b => b.UserID == token.UserID).FirstOrDefault();
            if(updateToken!=null)
            {
                updateToken.CreateDate = token.CreateDate;
                updateToken.ExpirationDate = token.ExpirationDate;
                updateToken.UserToken = token.UserToken;
                _context.Token.Update(updateToken);
                token = updateToken;
            }
            else
            {
                _context.Token.Add(token);
            }
            await _context.SaveChangesAsync();
            return token;
        }

        public async Task<IEnumerable<Token>> Find()
        {
            return await _context.Token.ToListAsync();
        }

        public async Task<Token> Generate(int id)
        {
            string hash = GenerateHash();
            Token token = new Token();
            token.UserID = id;
            token.UserToken = hash;
            token.CreateDate = DateTime.Now;
            token.ExpirationDate = DateTime.Now.AddHours(6);
            return token;
        }

        private string GenerateHash()
        {
            Random rand = new Random();
            string textToken = rand.Next(1, 10) + "a" + DateTime.Now.AddDays(rand.Next(1, 10)) + rand.Next(1, 10) + DateTime.Now + rand.Next(1, 10);
            var data = Encoding.ASCII.GetBytes(textToken);
            var sha1 = new SHA1CryptoServiceProvider();
            var userToken = sha1.ComputeHash(data);
            string token = Convert.ToBase64String(userToken);
            return token;
        }

        public async Task<Token> FindOne(int userID)
        {
            return await _context.Token.Where(b => b.UserID == userID).FirstOrDefaultAsync();
        }

        public async Task<Token> FindOne(string userToken)
        {
            return await _context.Token.Where(b => b.UserToken == userToken).FirstOrDefaultAsync();
        }

        public async Task Delete(int userID)
        {
            var tokenToDelete = _context.Token.Where(b => b.UserID == userID).FirstOrDefault();
            _context.Token.Remove(tokenToDelete);
            await _context.SaveChangesAsync();
        }

    }
}