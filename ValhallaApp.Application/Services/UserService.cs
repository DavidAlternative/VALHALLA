using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValhallaApp.Application.Interfaces;
using ValhallaApp.Application.Requests;
using ValhallaApp.Application.Responses;
using ValhallaApp.Domain.Entities;
using ValhallaApp.Domain.Interfaces;

namespace ValhallaApp.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public void AddUser(CreateUserRequest request)
        {
            var user = _mapper.Map<User>(request);
            _repository.AddUser(user);
        }

        public void DeleteUser(DeleteUserRequest request)
        {
            var user = _mapper.Map<User>(request);
            _repository.DeleteUser(user);
        }

        public IEnumerable<UserResponse> GetUsers()
        {
            var user = _repository.GetUsers();
            var userResponse = _mapper.Map<IEnumerable<UserResponse>>(user);
            return userResponse;
        }

        public void UpdateUser(UpdateUserRequest request)
        {
            var user = _mapper.Map<User>(request);
            _repository.UpdateUser(user);
        }
    }
}
