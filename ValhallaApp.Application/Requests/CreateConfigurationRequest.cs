﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValhallaApp.Application.Requests
{
    public class CreateConfigurationRequest
    {
        public int ConfigurationId { get; set; }
        public string? Frenos { get; set; }
        public string? Llantas { get; set; }
        public string? Pintura { get; set; }
        public string? Vista { get; set; }
        public string? AsientosElectricos { get; set; }
        public string? Cinturones { get; set; }
        public string? Bordado { get; set; }
        public string? AsistenciaAutopista { get; set; }
        public string? AperturaTraseraSmart { get; set; }
        public string? VisionNocturna { get; set; }
        public string? WashingPackage { get; set; }
    }
}
