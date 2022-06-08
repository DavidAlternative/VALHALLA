using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValhallaApp.Application.Requests;

namespace ValhallaApp.Application.Validators
{
    public class UpdateOptionValidator : AbstractValidator<UpdateOptionRequest>
    {
        public UpdateOptionValidator()
        {
            RuleFor(x => x.OptionId)
                .NotEmpty()
                .WithMessage("El campo OptionID no puede estar vacío.");
            RuleFor(x => x.Color)
               .NotEmpty()
               .WithMessage("El campo Color no puede estar vacío.");
        }
    }
}
