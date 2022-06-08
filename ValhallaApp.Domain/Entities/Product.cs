using System;
using System.Collections.Generic;

namespace ValhallaApp.Domain.Entities
{
    public partial class Product
    {
        public Product()
        {
            Orders = new HashSet<Order>();
        }

        public int ProductId { get; set; }
        public string? Brand { get; set; }
        public long? UnitPrice { get; set; }
        public string? Model { get; set; }
        public int? Year { get; set; }
        public int? CategoryId { get; set; }
        public int? UnitsInStock { get; set; }
        public int? UnitsInOrder { get; set; }
        public int? OptionId { get; set; }

        public virtual Category? Category { get; set; }
        public virtual Option? Option { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
