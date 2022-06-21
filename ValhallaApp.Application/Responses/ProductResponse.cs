using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValhallaApp.Application.Responses
{
    public class ProductResponse
    {
        public int ProductId { get; set; }
        public string? Brand { get; set; }
        public long? UnitPrice { get; set; }
        public string? Model { get; set; }
        public int? Year { get; set; }
        public int? CategoryId { get; set; }
        public int? UnitsInStock { get; set; }
        public int? UnitsInOrder { get; set; }
        public int? OptionId { get; set; }
    }
}
