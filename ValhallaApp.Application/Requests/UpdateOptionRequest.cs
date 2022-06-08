using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValhallaApp.Application.Requests
{
    public class UpdateOptionRequest
    {
        public int OptionId { get; set; }
        public string? Color { get; set; }

    }
}
