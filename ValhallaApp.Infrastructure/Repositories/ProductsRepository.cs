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
    public class ProductsRepository: IProductsRepository
    {
        private ValhallaContext _context;

        public ProductsRepository(ValhallaContext context)
        {
            _context = context;
        }

        public IEnumerable<Product> GetProducts()
        {
            return _context.Products;
        }

        public void AddProduct(Product product)
        {
            _context.Products.Add(product); 
            _context.SaveChanges();
   
        }

        public void UpdateProduct(Product product)
        {
            var ProductsE = _context.Products.FirstOrDefault(x => x.ProductId == product.ProductId);
            if (ProductsE != null)
            {
                ProductsE.Brand = product.Brand;
                ProductsE.UnitPrice = product.UnitPrice;
                ProductsE.Model = product.Model;
                ProductsE.Year = product.Year;
                ProductsE.CategoryId = product.CategoryId;
                ProductsE.UnitsInStock = product.UnitsInStock;
                ProductsE.UnitsInOrder = product.UnitsInOrder;
                ProductsE.OptionId = product.OptionId;
            }
            _context.SaveChanges();
        }

        public void DeleteProduct(Product product)
        {
            var ProductsE = _context.Products.FirstOrDefault(x => x.ProductId == product.ProductId);
            if (ProductsE != null)
            {
                _context.Remove(ProductsE);
            } 
            _context.SaveChanges();
        }
    }
}
