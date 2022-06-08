using System;
using System.Collections.Generic;

namespace ValhallaApp.Domain.Entities
{
    public partial class Option
    {
        public Option()
        {
            Products = new HashSet<Product>();
        }

        public int OptionId { get; set; }
        public string? Color { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
