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

        public UsersController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
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

        [HttpGet]
        public async Task<List<String>> GetEmails()
        {
            return await _userRepository.GetEmails();
        }

        [HttpGet("{email}")]
        public async Task<Boolean> VerifyEmail(string email)
        {
            return await _userRepository.VerifyEmail(email);
        }

        [HttpPost]
        public async Task<ActionResult<User>> AddUser([FromBody] User user)
        {
            var newUser = await _userRepository.Create(user);
            return CreatedAtAction(nameof(GetUsers), new {id = newUser.UserID}, newUser);
        }

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
