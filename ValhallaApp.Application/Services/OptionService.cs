using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValhallaApp.Application.Interfaces;
using ValhallaApp.Domain.Interfaces;

namespace ValhallaApp.Application.Services
{
    public class OptionService : IOptionService
    {
        private readonly IProductsRepository _repository;
        private readonly IMapper _mapper;

        public OptionService(IProductsRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
    }
}
