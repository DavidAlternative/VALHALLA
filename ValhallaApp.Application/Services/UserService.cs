using AutoMapper;
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
            var users = _repository.GetUsers();
            var usersResponse = _mapper.Map<IEnumerable<UserResponse>>(users);
            return usersResponse;
        }

        public void UpdateUser(UpdateUserRequest request)
        {
            var user = _mapper.Map<User>(request);
            _repository.UpdateUser(user);
        }
    }
}
