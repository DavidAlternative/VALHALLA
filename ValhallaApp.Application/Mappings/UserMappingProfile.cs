﻿using AutoMapper;
using ValhallaApp.Application.Requests;
using ValhallaApp.Application.Responses;
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

            CreateMap<User, UserResponse>();
        }
    }
}
