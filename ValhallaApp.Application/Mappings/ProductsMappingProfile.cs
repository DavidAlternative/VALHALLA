using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValhallaApp.Application.Requests;
using ValhallaApp.Domain.Entities;


namespace ValhallaApp.Application.Mappings
{
    public class ProductsMappingProfile: Profile
    {
        public ProductsMappingProfile()
        {
            CreateMap<CreateProductRequest, Product>();
            CreateMap<Product, CreateProductRequest>();

            CreateMap<UpdateProductRequest, Product>();
            CreateMap<Product, UpdateProductRequest>();

            CreateMap<DeleteProductRequest, Product>();
            CreateMap<Product, DeleteProductRequest>();
        }
    }
}
