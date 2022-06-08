using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ValhallaApp.Domain.Entities;
using ValhallaApp.Infrastructure.Persistence;
using ValhallaApp.Domain.Interfaces;
using AutoMapper;
using ValhallaApp.Application.Requests;

namespace ValhallaApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _repository;
        private readonly IMapper _mapper;

        public UserController(IUserRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]

        public IActionResult Get()
        {
            return Ok(_repository.GetUsers());      
        }

        [HttpPost]

        public IActionResult Post(CreateUserRequest request)
        {
            var user = _mapper.Map<User>(request);
            _repository.AddUser(user);
            return Ok();
        }

        [HttpPut]

        public IActionResult Put(UpdateUserRequest request)
        {
            var user = _mapper.Map<User>(request);
            _repository.UpdateUser(user);
            return Ok();
        }

        [HttpDelete]

        public IActionResult Delete(DeleteUserRequest request)
        {
            var user = _mapper.Map<User>(request);
            _repository.DeleteUser(user);
            return Ok();
        }
    }
}
