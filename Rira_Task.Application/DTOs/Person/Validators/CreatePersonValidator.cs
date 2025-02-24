using FluentValidation;
using Rira_Task.Application.DTOs.Person;

namespace Rira_Task.Application.DTOs.FoodProgram.Validators
{
    public class CreatePersonValidator : AbstractValidator<CreatePersonDto>
    {
        public CreatePersonValidator()
        {
            Include(new IPersonValidator());
        }
    }
}
