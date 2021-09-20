using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DameraAPI.DameraSOA.UserNS.Model;

namespace DameraAPI.DameraSOA.UserNS.Service
{
    public class UserQueryHandler : IUserQueryHandler
    {
        private readonly IUserRepository _userRepository;

        public UserQueryHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<IEnumerable<User>> Get()
        {
            return await _userRepository.FindAll();
        }

        public async Task<User> Get(int id)
        {
            return await _userRepository.FindOne(id);
        }
    }
}
