using Microsoft.EntityFrameworkCore;

namespace UsersApi.Models
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