using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValhallaApp.Domain.Entities;
using ValhallaApp.Domain.Interfaces;
using ValhallaApp.Infrastructure.Persistence;

namespace ValhallaApp.Infrastructure.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private ValhallaContext _context;

        public OrderRepository(ValhallaContext context)
        {
            _context = context;
        }

        public IEnumerable<Order> GetOrders()
        {
            return _context.Orders;
        }

        public void AddOrder(Order order)
        {
            _context.Orders.Add(order);
            _context.SaveChanges();
        }

        public void UpdateOrder(Order order)
        {
            var orderE = _context.Orders.FirstOrDefault(x => x.OrderId == order.OrderId);
            if (orderE != null)
            {
                orderE.UserId = order.UserId;
                orderE.OrderDate = order.OrderDate;
                orderE.Price = order.Price;
                orderE.ShippedDate = order.ShippedDate;
                orderE.ShipVia = order.ShipVia;
                orderE.ShipAddress = order.ShipAddress;
                orderE.ShipName = order.ShipName;
                orderE.ShipCity = order.ShipCity;
                orderE.ShipRegion = order.ShipRegion;
                orderE.ShipPostalCode = order.ShipPostalCode;
                orderE.ProductId = order.ProductId;
                orderE.ConfiguratedId = order.ConfiguratedId;
            }
            _context.SaveChanges();
        }

        public void DeleteOrder(Order order)
        {
            var orderE = _context.Orders.FirstOrDefault(x => x.OrderId == order.OrderId);
            if (orderE != null)
            {
                _context.Remove(orderE);
            }
            _context.SaveChanges();
        }
    }
}
