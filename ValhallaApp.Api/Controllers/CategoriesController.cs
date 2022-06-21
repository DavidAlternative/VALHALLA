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
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _service;

        public CategoriesController(ICategoryService service)
        {
            _service = service;
        }

        [HttpGet]

        public IActionResult Get()
        {
            return Ok(_service.GetCategory());
        }

        [HttpPost]

        public IActionResult Post(CreateCategoryRequest request)
        {
            _service.AddCategory(request);
            return Ok();

        }

        [HttpPut]

        public IActionResult Put(UpdateCategoryRequest request)
        {
            _service.UpdateCategory(request);   
            return Ok();
        }

        [HttpDelete]

        public IActionResult Delete(DeleteCategoryRequest request)
        {
            _service.DeleteCategory(request);
            return Ok();
        }

    }
}
