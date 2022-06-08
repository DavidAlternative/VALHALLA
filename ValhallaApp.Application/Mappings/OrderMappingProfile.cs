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
    public class OrderMappingProfile : Profile
    {
        public OrderMappingProfile()
        {
            CreateMap<CreateOrderRequest, Order>();
            CreateMap<Order, CreateOrderRequest>();

            CreateMap<UpdateOrderRequest, Order>();
            CreateMap<Order, UpdateOrderRequest>();

            CreateMap<DeleteOrderRequest, Order>();
            CreateMap<Order, DeleteOrderRequest>();
        }
    }
}