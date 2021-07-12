using Microsoft.EntityFrameworkCore;

namespace UsersApi.DameraSOA.UserNS.Model
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<User> User { get; set; }
    }
}