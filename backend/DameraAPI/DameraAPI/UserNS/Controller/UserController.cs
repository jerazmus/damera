using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DameraAPI.DameraSOA.UserNS.Model;
using DameraAPI.DameraSOA.UserNS.Service;

namespace DameraAPI.DameraAPI.UserNS.Controller
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserCommandHandler _userCommandHandler;
        private readonly IUserQueryHandler _userQueryHandler;

        public UserController(IUserCommandHandler userCommandHandler, IUserQueryHandler userQueryHandler)
        {
            _userCommandHandler = userCommandHandler;
            _userQueryHandler = userQueryHandler;
        }

        [HttpGet]
        public async Task<IEnumerable<User>> GetUsers()
        {
            return await _userQueryHandler.Get();
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(int id)
        {
            return await _userQueryHandler.Get(id);
        }

        [HttpPost]
        public async Task<User> VerifyUser([FromBody] User user)
        {
            return await _userQueryHandler.Verify(user);
        }

        [HttpPost]
        public async Task<ActionResult<User>> AddUser([FromBody] User user)
        {
            return await _userCommandHandler.Create(user);
        }
        
        [HttpPut]
        public async Task<ActionResult<User>> UpdateUser([FromBody] User user)
        {
            await _userCommandHandler.Update(user);
            return NoContent();
        }
        
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteUser(int id)
        {
            await _userCommandHandler.Delete(id);
            return NoContent();
        }
    }
}
