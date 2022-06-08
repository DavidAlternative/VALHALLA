using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValhallaApp.Domain.Entities;

namespace ValhallaApp.Domain.Interfaces
{
    public interface IConfiguratedProductRepository
    {
        IEnumerable<ConfiguratedProduct> GetConfiguratedProducts();

        void AddConfiguratedProduct(ConfiguratedProduct product);

        void UpdateConfiguratedProduct(ConfiguratedProduct product);

        void DeleteConfiguratedProduct(ConfiguratedProduct product);
    }
}
