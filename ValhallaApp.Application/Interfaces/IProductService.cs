using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValhallaApp.Application.Requests;
using ValhallaApp.Application.Responses;

namespace ValhallaApp.Application.Interfaces
{
    public interface IProductService
    {
        IEnumerable<ProductResponse> GetProducts();

        void AddProduct(CreateProductRequest product);

        void UpdateProduct(UpdateProductRequest product);

        void DeleteProduct(DeleteProductRequest product);
    }
}
