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
    public class CategoryMappingProfile : Profile
    {
        public CategoryMappingProfile()
        {
            CreateMap<CreateCategoryRequest, Category>();
            CreateMap<Category,CreateCategoryRequest>();

            CreateMap<UpdateCategoryRequest, Category>();
            CreateMap<Category,UpdateCategoryRequest>();

            CreateMap<DeleteCategoryRequest, Category>();
            CreateMap<Category, DeleteCategoryRequest>();

        }
    }
}
