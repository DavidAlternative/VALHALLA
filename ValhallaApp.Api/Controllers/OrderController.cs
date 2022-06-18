using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ValhallaApp.Application.Requests;
using ValhallaApp.Domain.Entities;
using ValhallaApp.Domain.Interfaces;

namespace ValhallaApp.Api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderRepository _repository;
        private readonly IMapper _mapper;

        public OrderController(IOrderRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]

        public IActionResult Get()
        {
            return Ok(_repository.GetOrders());
        }

        [HttpPost]

        public IActionResult Post(CreateOrderRequest request)
        {
            var order = _mapper.Map<Order>(request);
            _repository.AddOrder(order);
            return Ok();
        }

        [HttpPut]

        public IActionResult Put(CreateOrderRequest request)
        {
            var order = _mapper.Map<Order>(request);
            _repository.UpdateOrder(order);
            return Ok();
        }

        [HttpDelete]

        public IActionResult Delete(CreateOrderRequest request)
        {
            var order = _mapper.Map<Order>(request);
            _repository.DeleteOrder(order);
            return Ok();
        }
    }
}
