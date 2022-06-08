using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValhallaApp.Application.Requests
{
    public class DeleteOrderRequest
    {
        public string OrderId { get; set; } = null!;
    }
}
