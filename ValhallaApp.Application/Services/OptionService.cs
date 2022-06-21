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
    public class OptionService : IOptionService
    {
        private readonly IOptionRepository _repository;
        private readonly IMapper _mapper;

        public OptionService(IOptionRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public void AddOption(CreateOptionRequest request)
        {
            var option = _mapper.Map<Option>(request);
            _repository.AddOption(option);
        }

        public void DeleteOption(DeleteOptionRequest request)
        {
            var option = _mapper.Map<Option>(request);
            _repository.DeleteOption(option);
        }

        public IEnumerable<OptionResponse> GetOption()
        {
            var option = _repository.GetOption();
            var optionresponse = _mapper.Map<IEnumerable<OptionResponse>>(option);
            return optionresponse;
        }

        public void UpdateOption(UpdateOptionRequest request)
        {
            var option = _mapper.Map<Option>(request);
            _repository.UpdateOption(option);
        }
    }
}
