using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValhallaApp.Domain.Entities;


namespace ValhallaApp.Domain.Interfaces
{
    public interface IProductsRepository
    {
        IEnumerable<Product> GetProducts();

        void AddProduct(Product product);

        void UpdateProduct(Product product);

        void DeleteProduct(Product product);
    }
}

