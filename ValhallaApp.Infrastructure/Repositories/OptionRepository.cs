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
    public class OptionRepository: IOptionRepository
    {
        private ValhallaContext _context;

        public OptionRepository(ValhallaContext context)
        {
            _context = context;
        }   

        public IEnumerable<Option> GetOption()
        {
            return _context.Options;
        }


        public void AddOption(Option option)
        {
            _context.Options.Add(option);
            _context.SaveChanges();
        }

        public void UpdateOption(Option option)
        {
            var OptionE= _context.Options.FirstOrDefault(x=> x.OptionId==option.OptionId);
            if (OptionE!=null)
            {
                OptionE.Color = option.Color;
            }
            _context.SaveChanges();
        }

        public void DeleteOption(Option option)
        {
            var OptionE = _context.Options.FirstOrDefault(x => x.OptionId == option.OptionId);
            if (OptionE != null)
            {
                _context.Remove(OptionE);
            }
            
            _context.SaveChanges();
        }


    }
}
