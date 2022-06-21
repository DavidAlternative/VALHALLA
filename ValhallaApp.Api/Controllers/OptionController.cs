using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ValhallaApp.Application.Requests;
using ValhallaApp.Domain.Interfaces;
using ValhallaApp.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using ValhallaApp.Application.Interfaces;

namespace ValhallaApp.Api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class OptionController : ControllerBase
    {
        private readonly IOptionService _service;

        public OptionController(IOptionService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_service.GetOption());
        }
        
        [HttpPost]
        public IActionResult Post(CreateOptionRequest request)
        {
            _service.AddOption(request);
            return Ok();
        }
        
        [HttpPut]
        public IActionResult Put(UpdateOptionRequest request)
        {
            _service.UpdateOption(request);
            return Ok();
        }

        [HttpDelete]

        public IActionResult Delete(DeleteOptionRequest request)
        {
            _service.DeleteOption(request);
            return Ok();
        }

    }
}
