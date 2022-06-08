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
    public class CreateProductValidator : AbstractValidator<CreateProductRequest>
    {
        public CreateProductValidator()
        {
            RuleFor(x => x.ProductId)
               .NotEmpty()
               .WithMessage("El campo ProductID no puede estar vacío.");

            RuleFor(x => x.Brand)
              .NotEmpty()
              .WithMessage("El campo Brand no puede estar vacío.");

            RuleFor(x => x.UnitPrice)
              .NotEmpty()
              .WithMessage("El campo UnitPrice no puede estar vacío.");

            RuleFor(x => x.Model)
              .NotEmpty()
              .WithMessage("El campo Model no puede estar vacío.");

            RuleFor(x => x.Year)
              .NotEmpty()
              .WithMessage("El campo Year no puede estar vacío.");

            RuleFor(x => x.CategoryId)
              .NotEmpty()
              .WithMessage("El campo CategoryID no puede estar vacío.");

            RuleFor(x => x.UnitsInStock)
              .NotEmpty()
              .WithMessage("El campo UnitInStock no puede estar vacío.");

            RuleFor(x => x.UnitsInOrder)
              .NotEmpty()
              .WithMessage("El campo UnitInOrder no puede estar vacío.");

            RuleFor(x => x.OptionId)
               .NotEmpty()
               .WithMessage("El campo OptionID no puede estar vacío.");


        }
    }
}
