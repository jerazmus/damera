using Microsoft.EntityFrameworkCore;

namespace DameraAPI.DameraSOA.TokenNS.Model
{
    public class TokenContext : DbContext
    {
        public TokenContext(DbContextOptions<TokenContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Token> Token { get; set; }
    }
}