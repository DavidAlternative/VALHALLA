using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ValhallaApp.Application.Interfaces;
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
        private readonly IOrderService _service;

        public OrderController(IOrderService service)
        {
            _service = service;
        }


        [HttpGet]

        public IActionResult Get()
        {
            return Ok(_service.GetOrders());
        }

        [HttpPost]

        public IActionResult Post(CreateOrderRequest request)
        {
            _service.AddOrder(request);
            return Ok();
        }

        [HttpPut]

        public IActionResult Put(UpdateOrderRequest request)
        {
            _service.UpdateOrder(request);
            return Ok();
        }

        [HttpDelete]

        public IActionResult Delete(DeleteOrderRequest request)
        {
            _service.DeleteOrder(request);
            return Ok();
        }
    }
}
