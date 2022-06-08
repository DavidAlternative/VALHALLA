using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValhallaApp.Application.Requests;
using ValhallaApp.Domain.Entities;

namespace ValhallaApp.Application.Validators
{
    public class CreateConfiguratedProductValidator : AbstractValidator<CreateConfiguratedProductRequest>
    {
        public CreateConfiguratedProductValidator()
        {
            RuleFor(x => x.ConfiguratedId)
                .NotEmpty()
                .WithMessage("El campo ConfiguratedId no puede estar vacío.");
            RuleFor(x => x.UnitPrice)
                .NotEmpty()
                .WithMessage("El campo UnitPrice no puede estar vacío.");
            RuleFor(x => x.ConfigurationId)
                .NotEmpty()
                .WithMessage("El campo ConfigurationId no puede estar vacío.");
        }
    }
}
