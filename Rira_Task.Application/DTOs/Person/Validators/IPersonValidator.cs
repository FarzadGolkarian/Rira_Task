using FluentValidation;
using Rira_Task.Application.DTOs.Person.Interfaces;

namespace Rira_Task.Application.DTOs.Person.Validators
{
    public class IPersonValidator : AbstractValidator<IPerson>
    {
        public IPersonValidator()
        {

            RuleFor(r => r.Name)
                .NotEmpty()
                .WithMessage("{PropertyName} is required !")
                .MaximumLength(50)
                .NotNull();


            RuleFor(r => r.NationalCode)
                .NotEmpty()
                .WithMessage("{PropertyName} is required !")
                .MinimumLength(10)
                .MaximumLength(10)
                .NotNull();
        }

    }
}
