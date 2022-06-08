using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValhallaApp.Application.Requests;

namespace ValhallaApp.Application.Validators
{
    public class DeleteCategoryValidator : AbstractValidator<DeleteCategoryRequest>
    {
        public DeleteCategoryValidator()
        {
            RuleFor(x => x.CategoryId)
                .NotEmpty()
                .WithMessage("El campo CategoryID no puede estar vacío.");
        }
    }
}
