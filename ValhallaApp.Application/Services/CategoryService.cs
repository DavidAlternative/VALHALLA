using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValhallaApp.Application.Interfaces;
using ValhallaApp.Application.Requests;
using ValhallaApp.Application.Responses;
using ValhallaApp.Domain.Entities;
using ValhallaApp.Domain.Interfaces;

namespace ValhallaApp.Application.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _repository;
        private readonly IMapper _mapper;
        public CategoryService(ICategoryRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public void AddCategory(CreateCategoryRequest request)
        {
            var category = _mapper.Map<Category>(request);
            _repository.AddCategory(category);
        }

        public void DeleteCategory(DeleteCategoryRequest request)
        {
            var category = _mapper.Map<Category>(request);
            _repository.DeleteCategory(category);
        }

        public IEnumerable<CategoryResponse> GetCategory()
        {
            var category = _repository.GetCategory();
            var categoryResponse = _mapper.Map<IEnumerable<CategoryResponse>>(category);
            return categoryResponse;
        }

        public void UpdateCategory(UpdateCategoryRequest request)
        {
            var category = _mapper.Map<Category>(request);
            _repository.UpdateCategory(category);
        }
    }
}
