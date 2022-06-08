using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValhallaApp.Domain.Entities;
using ValhallaApp.Domain.Interfaces;
using ValhallaApp.Infrastructure.Persistence;

namespace ValhallaApp.Infrastructure.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private ValhallaContext _context;

        public CategoryRepository(ValhallaContext context)
        {
            _context = context;
        }

        public IEnumerable<Category> GetCategory()
        {
            return _context.Categories;
        }

        public void AddCategory(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
        }

        public void UpdateCategory(Category category)
        {
            var categoryE = _context.Categories.FirstOrDefault(x=>x.CategoryId==category.CategoryId);
            if (categoryE!=null)
            {
                categoryE.CategoryName = category.CategoryName;
            }
            _context.SaveChanges();
        }

        public void DeleteCategory(Category category)
        {
            var categoryE = _context.Categories.FirstOrDefault(x => x.CategoryId == category.CategoryId);
            if (categoryE != null)
            {
                _context.Remove(categoryE);
            }
            _context.SaveChanges();
        }
    }
}
