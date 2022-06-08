using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValhallaApp.Application.Requests;

namespace ValhallaApp.Application.Validators
{
    public class DeleteConfiguratedProductValidator : AbstractValidator<DeleteConfiguratedProductRequest>
    {
        public DeleteConfiguratedProductValidator()
        {
            RuleFor(x => x.ConfiguratedId)
                .NotEmpty()
                .WithMessage("El campo ConfiguratedId no puede estar vacío.");
        }
    }
}
