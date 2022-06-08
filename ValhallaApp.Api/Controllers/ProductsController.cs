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
    public class ProductsController : ControllerBase
    {
        private readonly IProductsRepository _repository;
        private readonly IMapper _mapper;


        public ProductsController(IProductsRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_repository.GetProducts());
        }

        [HttpPost]
        public IActionResult Post(CreateProductRequest request)
        {
            var products = _mapper.Map<Product>(request);
            _repository.AddProduct(products);
            return Ok();
        }


        [HttpPut]
        public IActionResult Put(UpdateProductRequest request)
        {
            var product = _mapper.Map<Product>(request);
            _repository.UpdateProduct(product);
            return Ok();

        }

        [HttpDelete]

        public IActionResult Delete(DeleteProductRequest request)
        {
            var product = _mapper.Map<Product>(request);
            _repository.DeleteProduct(product);
            return Ok();
        }


    }
}
