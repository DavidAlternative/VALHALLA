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
    public class CreateOrderValidator : AbstractValidator<CreateOrderRequest>
    {
        public CreateOrderValidator()
        {
            RuleFor(x => x.OrderId)
                .NotEmpty()
                .WithMessage("El campo OrderId no puede estar vacío.");
            RuleFor(x => x.UserId)
                .NotEmpty()
                .WithMessage("El campo UserId no puede estar vacío.");
            RuleFor(x => x.OrderDate)
                .NotEmpty()
                .WithMessage("El campo OrderDate no puede estar vacío.");
            RuleFor(x => x.Price)
                .NotEmpty()
                .WithMessage("El campo Price no puede estar vacío.");
            RuleFor(x => x.ShippedDate)
                .NotEmpty()
                .WithMessage("El campo ShippedDate no puede estar vacío.");
            RuleFor(x => x.ShipVia)
                .NotEmpty()
                .WithMessage("El campo ShipVia no puede estar vacío.");
            RuleFor(x => x.ShipAddress)
                .NotEmpty()
                .WithMessage("El campo ShipAddress no puede estar vacío.");
            RuleFor(x => x.ShipName)
                .NotEmpty()
                .WithMessage("El campo ShipName no puede estar vacío.");
            RuleFor(x => x.ShipCity)
                .NotEmpty()
                .WithMessage("El campo ShipCity no puede estar vacío.");
            RuleFor(x => x.ShipRegion)
                .NotEmpty()
                .WithMessage("El campo ShipRegion no puede estar vacío.");
            RuleFor(x => x.ShipPostalCode)
                .NotEmpty()
                .WithMessage("El campo ShipPostalCode no puede estar vacío.");
            RuleFor(x => x.ProductId)
                .NotEmpty()
                .WithMessage("El campo ProductId no puede estar vacío.");
            RuleFor(x => x.ConfiguratedId)
                .NotEmpty()
                .WithMessage("El campo ConfiguratedId no puede estar vacío.");
        }
    }
}
