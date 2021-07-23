using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UsersApi.DameraSOA.UserNS.Model;

namespace UsersApi.DameraSOA.UserNS.Service
{
    public class UserCommandHandler : IUserCommandHandler
    {
        private readonly IUserRepository _userRepository;

        public UserCommandHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User> Create(User user)
        {
            if (_userRepository.UserExists(user.Email).Result)
            {
                throw new DuplicateWaitObjectException("Email is already registered!");
            }
            else
            {
                var newUser = await _userRepository.Save(user);
                return newUser;
            }
        }

        public async Task Update(User user)
        {
            if (!_userRepository.UserExists(user.Email).Result)
            {
                throw new KeyNotFoundException("User not found!");
            }
            await _userRepository.Update(user);
        }

        public async Task Delete(int id)
        {
            var userToDelete = await _userRepository.FindOne(id);
            if (userToDelete == null)
            {
                throw new KeyNotFoundException("User not found!");
            }
            await _userRepository.Delete(userToDelete.ID);
        }
    }
}
