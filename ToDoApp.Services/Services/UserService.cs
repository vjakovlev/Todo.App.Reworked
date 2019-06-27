using System;
using System.Collections.Generic;
using System.Text;
using ToDoApp.DataAccess.Repositories;
using ToDoApp.Domain;

namespace ToDoApp.Services.Services
{
    public class UserService : IUserService
    {
        private IRepository<User> _userRepository;
        public UserService(IRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }

        public int AddNewUser(User entity)
        {
            return _userRepository.Insert(entity);
        }

        public User GetUserById(int id)
        {
            return _userRepository.GetById(id);
        }
    }
}
