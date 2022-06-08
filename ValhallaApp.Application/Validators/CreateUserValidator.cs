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
    public class CreateUserValidator : AbstractValidator<CreateUserRequest>
    {
        public CreateUserValidator()
        {
            
            RuleFor(x => x.UserId)
                .NotEmpty()
                .WithMessage("El campo UserId no puede estar vacío.");
            RuleFor(x => x.UserName)
                .NotEmpty()
                .WithMessage("El campo UserName no puede estar vacío.");
            RuleFor(x => x.FirstName)
                .NotEmpty()
                .WithMessage("El campo FirstName no puede estar vacío.");
            RuleFor(x => x.SecondName)
                .NotEmpty()
                .WithMessage("El campo SecondName no puede estar vacío.");
            RuleFor(x => x.FirstSurname)
                .NotEmpty()
                .WithMessage("El campo FirstSurname no puede estar vacío.");
            RuleFor(x => x.SecondSurname)
                .NotEmpty()
                .WithMessage("El campo SecondSurname no puede estar vacío.");
            RuleFor(x => x.Email)
                .NotEmpty()
                .WithMessage("El campo Email no puede estar vacío.");
            RuleFor(x => x.Phone)
                .NotEmpty()
                .WithMessage("El campo Phone no puede estar vacío.");
            RuleFor(x => x.Address)
                .NotEmpty()
                .WithMessage("El campo Address no puede estar vacío.");
            RuleFor(x => x.Birthdate)
                .NotEmpty()
                .WithMessage("El campo Birthdate no puede estar vacío.");
            RuleFor(x => x.Password)
                .NotEmpty()
                .WithMessage("El campo Password no puede estar vacío.");
            RuleFor(x => x.Dni)
                .NotEmpty()
                .WithMessage("El campo Dni no puede estar vacío.");
            RuleFor(x => x.City)
                .NotEmpty()
                .WithMessage("El campo City no puede estar vacío.");
            RuleFor(x => x.Country)
                .NotEmpty()
                .WithMessage("El campo Country no puede estar vacío.");
            RuleFor(x => x.PostalCode)
                .NotEmpty()
                .WithMessage("El campo PostalCode no puede estar vacío.");
            RuleFor(x => x.Region)
                .NotEmpty()
                .WithMessage("El campo Region no puede estar vacío.");
        }
    }
}
