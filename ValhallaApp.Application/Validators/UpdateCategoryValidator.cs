using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValhallaApp.Application.Requests;

namespace ValhallaApp.Application.Validators
{
    public class UpdateCategoryValidator : AbstractValidator<UpdateCategoryRequest>
    {
        public UpdateCategoryValidator()
        {
            RuleFor(x => x.CategoryId)
                .NotEmpty()
                .WithMessage("El campo CategoryID no puede estar vacío.");
            RuleFor(x => x.CategoryName)
                .NotEmpty()
                .WithMessage("El campo CategoryName no puede estar vacío.");
        }
    }
}
