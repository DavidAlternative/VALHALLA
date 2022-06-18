using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ValhallaApp.Application.Requests;
using ValhallaApp.Domain.Interfaces;
using ValhallaApp.Domain.Entities;
using Microsoft.AspNetCore.Authorization;

namespace ValhallaApp.Api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryRepository _repository;
        private readonly IMapper _mapper;

        public CategoriesController(ICategoryRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]

        public IActionResult Get()
        {
            return Ok(_repository.GetCategory());
        }

        [HttpPost]

        public IActionResult Post(CreateCategoryRequest request)
        {
            var category = _mapper.Map<Category>(request);
            _repository.AddCategory(category);
            return Ok();

        }

        [HttpPut]

        public IActionResult Put(UpdateCategoryRequest request)
        {
            var category = _mapper.Map<Category>(request);
            _repository.UpdateCategory(category);
            return Ok();
        }

        [HttpDelete]

        public IActionResult Delete(DeleteCategoryRequest request)
        {
            var category = _mapper.Map<Category>(request);
            _repository.DeleteCategory(category);
            return Ok();
        }

    }
}
