using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValhallaApp.Application.Requests;

namespace ValhallaApp.Application.Validators
{
    public class DeleteUserValidator : AbstractValidator<DeleteUserRequest>
    {
        public DeleteUserValidator()
        {

            RuleFor(x => x.UserId)
                .NotEmpty()
                .WithMessage("El campo UserId no puede estar vacío.");
        }
    }
}
