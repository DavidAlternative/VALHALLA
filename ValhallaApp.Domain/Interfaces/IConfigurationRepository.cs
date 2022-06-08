using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValhallaApp.Domain.Entities;

namespace ValhallaApp.Domain.Interfaces
{
    public interface IConfigurationRepository
    {
        IEnumerable<Configuration> GetConfigurations();
        void AddConfiguration(Configuration configuration);
        void UpdateConfiguration(Configuration configuration);
        void DeleteConfiguration(Configuration configuration);
    }
}
