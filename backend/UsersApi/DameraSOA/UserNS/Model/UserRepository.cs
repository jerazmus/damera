using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;


namespace UsersApi.DameraSOA.UserNS.Model
{
    public class UserRepository : IUserRepository
    {
        private readonly UserContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public UserRepository(UserContext context, IHttpContextAccessor httpContextAccessor) {
            _context = context;
            this._httpContextAccessor = httpContextAccessor;
        }

        public async Task<IEnumerable<User>> FindAll()
        {
            return await _context.User.ToListAsync();
        }

        public async Task<User> FindOne(int id)
        {
            return await _context.User.FindAsync(id);
        }

        public async Task<User> FindOne(string email)
        {
            return await _context.User.FirstOrDefaultAsync(user => user.Email == email);//_context.User.FindAsync(email);
        }

        public async Task GenerateCookies(string email, string userToken)
        {
            CookieOptions cookieOptions = new CookieOptions();
            cookieOptions.Expires = DateTime.Now.AddHours(6);
            _httpContextAccessor.HttpContext.Response.Cookies.Append("DameraToken", userToken, cookieOptions);
            _httpContextAccessor.HttpContext.Response.Cookies.Append("DameraLogin", email, cookieOptions);
        }

        public async Task DeleteCookies()
        {
            _httpContextAccessor.HttpContext.Response.Cookies.Delete("DameraLogin");
            _httpContextAccessor.HttpContext.Response.Cookies.Delete("DameraToken");
        }

        public async Task<User> Save(User user)
        {
            string passwordHash = BCrypt.Net.BCrypt.HashPassword(user.Password);
            user.Password = passwordHash;
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

        public async Task<bool> PasswordSignInAsync(string email, string password)
        {
            User user = await FindOne(email);
            bool verified = BCrypt.Net.BCrypt.Verify(password, user.Password);
            //return _context.User.Where(user => user.Email == email).Any(user => user.Password == password);
            return verified;
            
        }

    }
}