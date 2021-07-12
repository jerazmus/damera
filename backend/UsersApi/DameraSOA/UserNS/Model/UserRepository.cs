using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace UsersApi.DameraSOA.UserNS.Model
{
    public class UserRepository : IUserRepository
    {
        private readonly UserContext _context;

        public UserRepository(UserContext context) {
            _context = context;
        }

        public async Task<IEnumerable<User>> FindAll()
        {
            return await _context.User.ToListAsync();
        }

        public async Task<User> FindOne(int id)
        {
            return await _context.User.FindAsync(id);
        }

        public async Task<User> Save(User user)
        {
            _context.User.Add(user);
            await _context.SaveChangesAsync();
            return user;
        }

        public async Task Update(User user)
        {
            _context.Entry(user).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var userToDelete = await _context.User.FindAsync(id);
            _context.User.Remove(userToDelete);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> UserExists(string email)
        {
            List<string> emailList = await _context.User.Select(user => user.Email).ToListAsync();
            if (emailList.Any(e => e == email))
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
    }
}