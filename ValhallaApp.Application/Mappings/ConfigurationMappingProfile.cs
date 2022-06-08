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
    public class ConfigurationMappingProfile : Profile
    {
        public ConfigurationMappingProfile()
        {
            CreateMap<CreateConfigurationRequest, Configuration>();
            CreateMap<Configuration, CreateConfigurationRequest>();

            CreateMap<UpdateConfigurationRequest, Configuration>();
            CreateMap<Configuration, UpdateConfigurationRequest>();

            CreateMap<DeleteConfigurationRequest, Configuration>();
            CreateMap<Configuration, DeleteConfigurationRequest>();
        }
    }
}
