using Microsoft.EntityFrameworkCore;

namespace DameraAPI.DameraSOA.UserNS.Model
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