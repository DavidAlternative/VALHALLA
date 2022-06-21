using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValhallaApp.Application.Interfaces;
using ValhallaApp.Application.Requests;
using ValhallaApp.Application.Responses;
using ValhallaApp.Domain.Entities;
using ValhallaApp.Domain.Interfaces;

namespace ValhallaApp.Application.Services
{
    public class ConfigurationService : IConfigurationService
    {
        private readonly IConfigurationRepository _repository;
        private readonly IMapper _mapper;
        public ConfigurationService(IConfigurationRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public void AddConfiguration(CreateConfigurationRequest request)
        {
            var configuration = _mapper.Map<Configuration>(request);
            _repository.AddConfiguration(configuration);
        }

        public void DeleteConfiguration(DeleteConfigurationRequest request)
        {
            var configuration = _mapper.Map<Configuration>(request);
            _repository.DeleteConfiguration(configuration);
        }

        public IEnumerable<ConfigurationResponse> GetConfigurations()
        {
            var configuration = _repository.GetConfigurations();
            var configurationResponse = _mapper.Map<IEnumerable<ConfigurationResponse>>(configuration);
            return configurationResponse;
        }

        public void UpdateConfiguration(UpdateConfigurationRequest request)
        {
            var configuration = _mapper.Map<Configuration>(request);
            _repository.UpdateConfiguration(configuration);
        }
    }
}
