using FluentValidation;

namespace Rira_Task.Application.DTOs.Person.Validators
{
    public class CreatePersonValidator : AbstractValidator<CreatePersonDto>
    {
        public CreatePersonValidator()
        {
            Include(new IPersonValidator());
        }
    }
}
