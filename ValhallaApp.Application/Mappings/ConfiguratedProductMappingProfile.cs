using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValhallaApp.Application.Requests;
using ValhallaApp.Application.Responses;
using ValhallaApp.Domain.Entities;

namespace ValhallaApp.Application.Mappings
{
    public class ConfiguratedProductMappingProfile : Profile
    {
        public ConfiguratedProductMappingProfile()
        {
            CreateMap<CreateConfiguratedProductRequest, ConfiguratedProduct>();
            CreateMap<ConfiguratedProduct, CreateConfiguratedProductRequest>();

            CreateMap<UpdateConfiguratedProductRequest, ConfiguratedProduct>();
            CreateMap<ConfiguratedProduct, UpdateConfiguratedProductRequest>();

            CreateMap<DeleteConfiguratedProductRequest, ConfiguratedProduct>();
            CreateMap<ConfiguratedProduct, DeleteConfiguratedProductRequest>();

            CreateMap<ConfiguratedProduct, ConfiguratedProductResponse>();
        }
    }
}
