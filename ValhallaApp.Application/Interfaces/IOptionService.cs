using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValhallaApp.Application.Requests;
using ValhallaApp.Application.Responses;

namespace ValhallaApp.Application.Interfaces
{
    public interface IOptionService
    {
        IEnumerable<OptionResponse> GetOption();

        void AddOption(CreateOptionRequest option);

        void UpdateOption(UpdateOptionRequest option);

        void DeleteOption(DeleteOptionRequest option);
    }
}
