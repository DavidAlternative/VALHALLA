using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValhallaApp.Application.Requests;
using ValhallaApp.Application.Responses;

namespace ValhallaApp.Application.Interfaces
{
    public interface IConfigurationService
    {
        IEnumerable<ConfigurationResponse> GetConfigurations();
        void AddConfiguration(CreateConfigurationRequest configuration);
        void UpdateConfiguration(UpdateConfigurationRequest configuration);
        void DeleteConfiguration(DeleteConfigurationRequest configuration);
    }
}
