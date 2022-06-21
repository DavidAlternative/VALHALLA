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
    public class ConfiguratedProductController : ControllerBase
    {
        private readonly IConfiguratedProductService _service;

        public ConfiguratedProductController(IConfiguratedProductService service)
        {
            _service = service;
        }

        [HttpGet]

        public IActionResult Get()
        {
            return Ok(_service.GetConfiguratedProducts());
        }

        [HttpPost]

        public IActionResult Post(CreateConfiguratedProductRequest request)
        {
            _service.AddConfiguratedProduct(request);
            return Ok();
        }

        [HttpPut]

        public IActionResult Put(UpdateConfiguratedProductRequest request)
        {
            _service.UpdateConfiguratedProduct(request);
            return Ok();
        }

        [HttpDelete]

        public IActionResult Delete(DeleteConfiguratedProductRequest request)
        {
            _service.DeleteConfiguratedProduct(request);
            return Ok();
        }
    }
}
