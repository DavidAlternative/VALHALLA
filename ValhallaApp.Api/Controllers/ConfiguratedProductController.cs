using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ValhallaApp.Application.Requests;
using ValhallaApp.Domain.Entities;
using ValhallaApp.Domain.Interfaces;

namespace ValhallaApp.Api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ConfiguratedProductController : ControllerBase
    {
        private readonly IConfiguratedProductRepository _repository;
        private readonly IMapper _mapper;

        public ConfiguratedProductController(IConfiguratedProductRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]

        public IActionResult Get()
        {
            return Ok(_repository.GetConfiguratedProducts());
        }

        [HttpPost]

        public IActionResult Post(CreateConfiguratedProductRequest request)
        {
            var configuratedProduct = _mapper.Map<ConfiguratedProduct>(request);
            _repository.AddConfiguratedProduct(configuratedProduct);
            return Ok();
        }

        [HttpPut]

        public IActionResult Put(UpdateConfiguratedProductRequest request)
        {
            var configuratedProduct = _mapper.Map<ConfiguratedProduct>(request);
            _repository.UpdateConfiguratedProduct(configuratedProduct);
            return Ok();
        }

        [HttpDelete]

        public IActionResult Delete(DeleteConfiguratedProductRequest request)
        {
            var configuratedProduct = _mapper.Map<ConfiguratedProduct>(request);
            _repository.DeleteConfiguratedProduct(configuratedProduct);
            return Ok();
        }
    }
}
