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
    public class UserMappingProfile : Profile
    {
        public UserMappingProfile()
        {
            CreateMap<CreateUserRequest, User>();
            CreateMap<User, CreateUserRequest>();

            CreateMap<UpdateUserRequest, User>();
            CreateMap<User, UpdateUserRequest>();

            CreateMap<DeleteUserRequest, User>();
            CreateMap<User, DeleteUserRequest>();
        }
    }
}
