using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValhallaApp.Application.Requests
{
    public class UpdateConfiguratedProductRequest
    {
        public int ConfiguratedId { get; set; }
        public long? UnitPrice { get; set; }
        public int? ConfigurationId { get; set; }
    }
}
