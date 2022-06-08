using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValhallaApp.Application.Requests
{
    public class UpdateOrderRequest
    {
        public string OrderId { get; set; } = null!;
        public string? UserId { get; set; }
        public DateTime? OrderDate { get; set; }
        public long? Price { get; set; }
        public DateTime? ShippedDate { get; set; }
        public string? ShipVia { get; set; }
        public string? ShipAddress { get; set; }
        public string? ShipName { get; set; }
        public string? ShipCity { get; set; }
        public string? ShipRegion { get; set; }
        public string? ShipPostalCode { get; set; }
        public int? ProductId { get; set; }
        public int? ConfiguratedId { get; set; }
    }
}
