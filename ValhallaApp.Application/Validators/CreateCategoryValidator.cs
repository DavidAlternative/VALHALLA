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
    public class CreateCategoryValidator: AbstractValidator<CreateCategoryRequest>
    {
        public CreateCategoryValidator()
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
