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
    public class ConfiguratedProductService : IConfiguratedProductService
    {
        private readonly IConfiguratedProductRepository _repository;
        private readonly IMapper _mapper;
        public ConfiguratedProductService(IConfiguratedProductRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public void AddConfiguratedProduct(CreateConfiguratedProductRequest request)
        {
            var configuratedProduct = _mapper.Map<ConfiguratedProduct>(request);
            _repository.AddConfiguratedProduct(configuratedProduct);
        }

        public void DeleteConfiguratedProduct(DeleteConfiguratedProductRequest request)
        {
            var configuratedProduct = _mapper.Map<ConfiguratedProduct>(request);
            _repository.DeleteConfiguratedProduct(configuratedProduct);
        }

        public IEnumerable<ConfiguratedProductResponse> GetConfiguratedProducts()
        {
            var configuratedProduct = _repository.GetConfiguratedProducts();
            var configuratedProductResponse = _mapper.Map<IEnumerable<ConfiguratedProductResponse>>(configuratedProduct);
            return configuratedProductResponse;
        }

        public void UpdateConfiguratedProduct(UpdateConfiguratedProductRequest request)
        {
            var configuratedProduct = _mapper.Map<ConfiguratedProduct>(request);
            _repository.UpdateConfiguratedProduct(configuratedProduct);
        }
    }
}
