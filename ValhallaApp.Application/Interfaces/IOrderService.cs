using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValhallaApp.Application.Requests;
using ValhallaApp.Application.Responses;

namespace ValhallaApp.Application.Interfaces
{
    public interface IOrderService
    {
        IEnumerable<OrderResponse> GetOrders();
        void AddOrder(CreateOrderRequest order);
        void UpdateOrder(UpdateOrderRequest order);
        void DeleteOrder(DeleteOrderRequest order);
    }
}
