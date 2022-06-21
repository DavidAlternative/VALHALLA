using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValhallaApp.Application.Requests;
using ValhallaApp.Application.Responses;

namespace ValhallaApp.Application.Interfaces
{
    public interface IConfiguratedProductService
    {
        IEnumerable<ConfiguratedProductResponse> GetConfiguratedProducts();

        void AddConfiguratedProduct(CreateConfiguratedProductRequest product);

        void UpdateConfiguratedProduct(UpdateConfiguratedProductRequest product);

        void DeleteConfiguratedProduct(DeleteConfiguratedProductRequest product);
    }
}
