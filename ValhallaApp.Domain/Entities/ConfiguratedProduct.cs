using System;
using System.Collections.Generic;

namespace ValhallaApp.Domain.Entities
{
    public partial class ConfiguratedProduct
    {
        public ConfiguratedProduct()
        {
            Orders = new HashSet<Order>();
        }

        public int ConfiguratedId { get; set; }
        public long? UnitPrice { get; set; }
        public int? ConfigurationId { get; set; }

        public virtual Configuration? Configuration { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
