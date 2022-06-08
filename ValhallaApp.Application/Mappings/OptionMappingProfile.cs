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
    public class OptionMappingProfile: Profile
    {
        public OptionMappingProfile()
        {
            CreateMap<CreateOptionRequest, Option>();
            CreateMap<Option, CreateOptionRequest>();

            CreateMap<UpdateOptionRequest, Option>();
            CreateMap<Option, UpdateOptionRequest>();

            CreateMap<DeleteOptionRequest, Option>();
            CreateMap<Option, DeleteOptionRequest>();
        }
    }
}
