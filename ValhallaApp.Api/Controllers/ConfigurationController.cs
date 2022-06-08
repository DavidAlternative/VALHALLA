using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ValhallaApp.Application.Requests;
using ValhallaApp.Domain.Entities;
using ValhallaApp.Domain.Interfaces;

namespace ValhallaApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConfigurationController : ControllerBase
    {
        private readonly IConfigurationRepository _repository;
        private readonly IMapper _mapper;

        public ConfigurationController(IConfigurationRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]

        public IActionResult Get()
        {
            return Ok(_repository.GetConfigurations());
        }

        [HttpPost]

        public IActionResult Post(CreateConfigurationRequest request)
        {
            var configuration = _mapper.Map<Configuration>(request);
            _repository.AddConfiguration(configuration);
            return Ok();
        }

        [HttpPut]

        public IActionResult Put(UpdateConfigurationRequest request)
        {
            var configuration = _mapper.Map<Configuration>(request);
            _repository.UpdateConfiguration(configuration);
            return Ok();
        }

        [HttpDelete]

        public IActionResult Delete(DeleteConfigurationRequest request)
        {
            var configuration = _mapper.Map<Configuration>(request);
            _repository.DeleteConfiguration(configuration);
            return Ok();
        }
    }
}
