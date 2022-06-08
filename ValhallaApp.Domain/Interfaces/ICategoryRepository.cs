using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValhallaApp.Domain.Entities;

namespace ValhallaApp.Domain.Interfaces
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetCategory();

        void AddCategory(Category category);

        void UpdateCategory(Category category);

        void DeleteCategory(Category category);
    }
}
