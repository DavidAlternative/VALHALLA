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
    public class ConfiguratedProductRepository : IConfiguratedProductRepository
    {
        private ValhallaContext _context;

        public ConfiguratedProductRepository(ValhallaContext context)
        {
            _context = context;
        }

        public IEnumerable<ConfiguratedProduct> GetConfiguratedProducts()
        {
            return _context.ConfiguratedProducts;
        }

        public void AddConfiguratedProduct(ConfiguratedProduct configuratedProduct)
        {
            _context.ConfiguratedProducts.Add(configuratedProduct);
            _context.SaveChanges();
        }

        public void UpdateConfiguratedProduct(ConfiguratedProduct configuratedProduct)
        {
            var configuratedProductE = _context.ConfiguratedProducts.FirstOrDefault(x => x.ConfiguratedId == configuratedProduct.ConfiguratedId);
            if (configuratedProductE != null)
            {
                configuratedProductE.ConfigurationId = configuratedProduct.ConfigurationId;
                configuratedProductE.UnitPrice = configuratedProduct.UnitPrice;
            }
            _context.SaveChanges();
        }

        public void DeleteConfiguratedProduct(ConfiguratedProduct configuratedProduct)
        {
            var configuratedProductE = _context.ConfiguratedProducts.FirstOrDefault(x => x.ConfiguratedId == configuratedProduct.ConfiguratedId);
            if (configuratedProductE != null)
            {
                _context.Remove(configuratedProductE);
            }
            _context.SaveChanges();
        }
    }
}
