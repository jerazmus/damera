using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UsersApi.Models;
using UsersApi.Repositories;

namespace UsersApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        private readonly UserContext _context;

        public UsersController(IUserRepository userRepository, UserContext userContext)
        {
            _userRepository = userRepository;
            _context = userContext;
        }

        [HttpGet]
        public async Task<IEnumerable<User>> GetUsers()
        {
            return await _userRepository.Get();
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(int id)
        {
            return await _userRepository.Get(id);
        }
        /*
        [HttpGet]
        public async Task<List<String>> GetEmails()
        {
            return await _userRepository.GetEmails();
        }
        */
        /*
        [HttpPost]
        public async Task<ActionResult<User>> Login([FromBody] User user,[FromBody] Token token)
        {
            List<string> emailList = await _context.User.Select(user => user.Email).ToListAsync();
            if(emailList.Any(e => e == user.Email))
            {
                var newToken = await _tokenRepository.Create(token);
                return CreatedAtAction(nameof(GetUsers), new {id = newToken.TokenID}, newToken);
            }
            else
            {
                //throw new BadRequest("Email is wrong!");
                return BadRequest("Email is wrong!");
            }
        }
        */
        [HttpPost]
        public async Task<ActionResult<User>> AddUser([FromBody] User user)
        {
            List<string> emailList = await _context.User.Select(user => user.Email).ToListAsync();
            if(emailList.Any(e => e == user.Email))
            {
                return BadRequest("Email is already taken!");
            }
            else
            {
            var newUser = await _userRepository.Create(user);
            return CreatedAtAction(nameof(GetUsers), new {id = newUser.UserID}, newUser);
            }
        }
        /*
        [HttpPut]
        public async Task<ActionResult<User>> UpdateUser(int id, [FromBody] User user)
        {
            if(id != user.UserID)
            {
                return BadRequest();
            }

            await _userRepository.Update(user);

            return NoContent();
        }
        */
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteUser(int id)
        {
            var userToDelete = await _userRepository.Get(id);
            if(userToDelete == null) {
                return NotFound();
            }

            await _userRepository.Delete(userToDelete.UserID);
            return NoContent();
        }
    }
}
