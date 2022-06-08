using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValhallaApp.Application.Requests;

namespace ValhallaApp.Application.Validators
{
    public class DeleteOrderValidator : AbstractValidator<DeleteOrderRequest>
    {
        public DeleteOrderValidator()
        {
            RuleFor(x => x.OrderId)
                .NotEmpty()
                .WithMessage("El campo OrderId no puede estar vacío.");
        }
    }
}
