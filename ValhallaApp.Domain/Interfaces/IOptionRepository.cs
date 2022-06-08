using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValhallaApp.Domain.Entities;


namespace ValhallaApp.Domain.Interfaces
{
    public interface IOptionRepository
    {
        IEnumerable<Option> GetOption();

        void AddOption(Option option);

        void UpdateOption(Option option);

        void DeleteOption(Option option);

    }
}
