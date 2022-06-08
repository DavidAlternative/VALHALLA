using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValhallaApp.Application.Requests;

namespace ValhallaApp.Application.Validators
{
    public class DeleteConfigurationValidator : AbstractValidator<DeleteConfigurationRequest>
    {
        public DeleteConfigurationValidator()
        {
            RuleFor(x => x.ConfigurationId)
                .NotEmpty()
                .WithMessage("El campo ConfigurationId no puede estar vacío.");
        }
    }
}
