using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValhallaApp.Application.Requests;

namespace ValhallaApp.Application.Validators
{
    public class UpdateConfigurationValidator : AbstractValidator<UpdateConfigurationRequest>
    {
        public UpdateConfigurationValidator()
        {
            RuleFor(x => x.ConfigurationId)
                .NotEmpty()
                .WithMessage("El campo ConfigurationId no puede estar vacío.");
            RuleFor(x => x.Frenos)
                .NotEmpty()
                .WithMessage("El campo Frenos no puede estar vacío.");
            RuleFor(x => x.Llantas)
                .NotEmpty()
                .WithMessage("El campo Llantas no puede estar vacío.");
            RuleFor(x => x.Pintura)
                .NotEmpty()
                .WithMessage("El campo Pintura no puede estar vacío.");
            RuleFor(x => x.Vista)
                .NotEmpty()
                .WithMessage("El campo Vista no puede estar vacío.");
            RuleFor(x => x.AsientosElectricos)
                .NotEmpty()
                .WithMessage("El campo AsientosElectricos no puede estar vacío.");
            RuleFor(x => x.Cinturones)
                .NotEmpty()
                .WithMessage("El campo Cinturones no puede estar vacío.");
            RuleFor(x => x.Bordado)
                .NotEmpty()
                .WithMessage("El campo Bordado no puede estar vacío.");
            RuleFor(x => x.AsistenciaAutopista)
                .NotEmpty()
                .WithMessage("El campo AsistenciaAutopista no puede estar vacío.");
            RuleFor(x => x.AperturaTraseraSmart)
                .NotEmpty()
                .WithMessage("El campo AperturaTraseraSmart no puede estar vacío.");
            RuleFor(x => x.VisionNocturna)
                .NotEmpty()
                .WithMessage("El campo VisionNocturnav no puede estar vacío.");
            RuleFor(x => x.WashingPackage)
                .NotEmpty()
                .WithMessage("El campo WashingPackage no puede estar vacío.");
        }
    
    }
}
