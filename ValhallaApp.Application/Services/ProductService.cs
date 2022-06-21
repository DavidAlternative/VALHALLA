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
    public class ProductService : IProductService
    {
        private readonly IProductsRepository _repository;
        private readonly IMapper _mapper;

        public ProductService(IProductsRepository repository, IMapper mapper)
        {
            _repository = repository;   
            _mapper = mapper;  

        }

        public void AddProduct(CreateProductRequest request)
        {
            var product = _mapper.Map<Product>(request);
            _repository.AddProduct(product);
            
        }

        public void DeleteProduct(DeleteProductRequest request)
        {
            var product = _mapper.Map<Product>(request);
            _repository.DeleteProduct(product);
        }

        public IEnumerable<ProductResponse> GetProducts()
        {
            var product = _repository.GetProducts();
            var productresponse = _mapper.Map<IEnumerable<ProductResponse>>(product);
            return productresponse;
        }

        public void UpdateProduct(UpdateProductRequest request)
        {
            var product = _mapper.Map<Product>(request);
            _repository.UpdateProduct(product);

        }
    }
}
