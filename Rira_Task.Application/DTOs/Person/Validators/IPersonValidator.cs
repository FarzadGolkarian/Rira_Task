using FluentValidation;
using Rira_Task.Application.DTOs.Person.Interfaces;

namespace Rira_Task.Application.DTOs.FoodProgram.Validators
{
    public class IPersonValidator : AbstractValidator<IPerson>
    {
        public IPersonValidator()
        {

            RuleFor(r => r.Name)
                .NotEmpty()
                .WithMessage("{PropertyName} is required !")
                .NotNull();


            RuleFor(r => r.NationalCode)
                .NotEmpty()
                .WithMessage("{PropertyName} is required !")
                .NotNull();
        }

    }
}
