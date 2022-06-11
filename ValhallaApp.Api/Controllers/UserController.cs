using Microsoft.AspNetCore.Mvc;
using ValhallaApp.Application.Requests;
using ValhallaApp.Domain.Interfaces;

namespace ValhallaApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _service;

        public UserController(IUserService service)
        {
            _service = service;
        }

        [HttpGet]

        public IActionResult Get()
        {
            return Ok(_service.GetUsers());      
        }

        [HttpPost]

        public IActionResult Post(CreateUserRequest request)
        {
            _service.AddUser(request);
            return Ok();
        }

        [HttpPut]

        public IActionResult Put(UpdateUserRequest request)
        {
            _service.UpdateUser(request);
            return Ok();
        }

        [HttpDelete]

        public IActionResult Delete(DeleteUserRequest request)
        {
            _service.DeleteUser(request);
            return Ok();
        }
    }
}
