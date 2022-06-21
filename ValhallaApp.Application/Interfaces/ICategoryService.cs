using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValhallaApp.Application.Requests;
using ValhallaApp.Application.Responses;

namespace ValhallaApp.Application.Interfaces
{
    public interface ICategoryService
    {
        IEnumerable<CategoryResponse> GetCategory();

        void AddCategory(CreateCategoryRequest category);

        void UpdateCategory(UpdateCategoryRequest category);

        void DeleteCategory(DeleteCategoryRequest category);
    }
}
