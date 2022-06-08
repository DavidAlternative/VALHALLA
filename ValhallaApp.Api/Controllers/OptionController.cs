using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ValhallaApp.Application.Requests;
using ValhallaApp.Domain.Interfaces;
using ValhallaApp.Domain.Entities;

namespace ValhallaApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OptionController : ControllerBase
    {
        private readonly IOptionRepository _repository;
        private readonly IMapper _mapper;

        public OptionController(IOptionRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_repository.GetOption());
        }
        
        [HttpPost]
        public IActionResult Post(CreateOptionRequest request)
        {
            var option = _mapper.Map<Option>(request);
            _repository.AddOption(option);
            return Ok();
        }
        
        [HttpPut]
        public IActionResult Put(UpdateOptionRequest request)
        {
            var option = _mapper.Map<Option>(request);
            _repository.UpdateOption(option);
            return Ok();
        }

        [HttpDelete]

        public IActionResult Delete(DeleteOptionRequest request)
        {
            var option = _mapper.Map<Option>(request);
            _repository.DeleteOption(option);
            return Ok();
        }

    }
}
