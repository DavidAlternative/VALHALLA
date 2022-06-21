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
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _service;

        public ProductsController(IProductService service)
        {
            _service = service;
        }
    
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_service.GetProducts());
        }

        [HttpPost]
        public IActionResult Post(CreateProductRequest request)
        {
            _service.AddProduct(request);
            return Ok();
        }


        [HttpPut]
        public IActionResult Put(UpdateProductRequest request)
        {
            _service.UpdateProduct(request);
            return Ok();

        }

        [HttpDelete]

        public IActionResult Delete(DeleteProductRequest request)
        {
            _service.DeleteProduct(request);
            return Ok();
        }


    }
}
