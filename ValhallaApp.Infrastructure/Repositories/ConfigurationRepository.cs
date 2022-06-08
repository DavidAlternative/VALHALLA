using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValhallaApp.Domain.Entities;
using ValhallaApp.Domain.Interfaces;
using ValhallaApp.Infrastructure.Persistence;

namespace ValhallaApp.Infrastructure.Repositories
{
    public class ConfigurationRepository : IConfigurationRepository
    {
        private ValhallaContext _context;

        public ConfigurationRepository(ValhallaContext context)
        {
            _context = context;
        }

        public IEnumerable<Configuration> GetConfigurations()
        {
            return _context.Configurations;
        }

        public void AddConfiguration(Configuration configuration)
        {
            _context.Configurations.Add(configuration);
            _context.SaveChanges();
        }

        public void UpdateConfiguration(Configuration configuration)
        {
            var ConfigurationE = _context.Configurations.FirstOrDefault(x => x.ConfigurationId == configuration.ConfigurationId);
            if (ConfigurationE != null)
            {
                ConfigurationE.Frenos = configuration.Frenos;
                ConfigurationE.Llantas = configuration.Llantas;
                ConfigurationE.Pintura = configuration.Pintura;
                ConfigurationE.Vista = configuration.Vista;
                ConfigurationE.AsientosElectricos = configuration.AsientosElectricos;
                ConfigurationE.Cinturones = configuration.Cinturones;
                ConfigurationE.Bordado = configuration.Bordado;
                ConfigurationE.AsistenciaAutopista = configuration.AsistenciaAutopista;
                ConfigurationE.AperturaTraseraSmart = configuration.AperturaTraseraSmart;
                ConfigurationE.VisionNocturna = configuration.VisionNocturna;
                ConfigurationE.WashingPackage = configuration.WashingPackage;
            }

            _context.SaveChanges();
        }

        public void DeleteConfiguration(Configuration configuration)
        {
            var ConfigurationE = _context.Configurations.FirstOrDefault(x => x.ConfigurationId == configuration.ConfigurationId);
            if (ConfigurationE != null)
            {
                _context.Remove(ConfigurationE);
            }
            _context.SaveChanges();

        }

    }
}
