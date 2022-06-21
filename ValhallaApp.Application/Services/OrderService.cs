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
    public class OrderService :IOrderService 
    {
        private readonly IOrderRepository _repository;
        private readonly IMapper _mapper;

        public OrderService(IOrderRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public void AddOrder(CreateOrderRequest request)
        {
            var order= _mapper.Map<Order>(request);
            _repository.AddOrder(order);
        }

        public void DeleteOrder(DeleteOrderRequest request)
        {
            var order = _mapper.Map<Order>(request);
            _repository.DeleteOrder(order);
        }

        public IEnumerable<OrderResponse> GetOrders()
        {
            var order = _repository.GetOrders();
            var orderresponse = _mapper.Map<IEnumerable<OrderResponse>>(order);
            return orderresponse;
        }

        public void UpdateOrder(UpdateOrderRequest request)
        {
            var order = _mapper.Map<Order>(request);
            _repository.UpdateOrder(order);
        }
    }
}
