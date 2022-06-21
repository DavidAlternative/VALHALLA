using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ValhallaApp.Application.Interfaces;
using ValhallaApp.Application.Requests;
using ValhallaApp.Domain.Entities;
using ValhallaApp.Domain.Interfaces;

namespace ValhallaApp.Api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ConfigurationController : ControllerBase
    {
        private readonly IConfigurationService _service;
        public ConfigurationController(IConfigurationService service)
        {
            _service = service;
        }

        [HttpGet]

        public IActionResult Get()
        {
            return Ok(_service.GetConfigurations());
        }

        [HttpPost]

        public IActionResult Post(CreateConfigurationRequest request)
        {
            _service.AddConfiguration(request);
            return Ok();
        }

        [HttpPut]

        public IActionResult Put(UpdateConfigurationRequest request)
        {
            _service.UpdateConfiguration(request);
            return Ok();
        }

        [HttpDelete]

        public IActionResult Delete(DeleteConfigurationRequest request)
        {
            _service.DeleteConfiguration(request);
            return Ok();
        }
    }
}
