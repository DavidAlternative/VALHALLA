using System;
using System.Collections.Generic;

namespace ValhallaApp.Domain.Entities
{
    public partial class Configuration
    {
        public Configuration()
        {
            ConfiguratedProducts = new HashSet<ConfiguratedProduct>();
        }

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

        public virtual ICollection<ConfiguratedProduct> ConfiguratedProducts { get; set; }
    }
}
