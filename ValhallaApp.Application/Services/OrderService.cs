using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValhallaApp.Application.Interfaces;
using ValhallaApp.Domain.Interfaces;

namespace ValhallaApp.Application.Services
{
    public class OrderService : IOrderService
    {
        private readonly IProductsRepository _repository;
        private readonly IMapper _mapper;

        public OrderService(IProductsRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
    }
}
