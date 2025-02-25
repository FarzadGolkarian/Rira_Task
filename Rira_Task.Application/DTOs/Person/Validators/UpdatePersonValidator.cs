using FluentValidation;
using Rira_Task.Application.DTOs.Person;

namespace Rira_Task.Application.DTOs.Person.Validators
{
    public class UpdatePersonValidator : AbstractValidator<UpdatePersonDto>
    {
        public UpdatePersonValidator()
        {
            Include(new IPersonValidator());
        }

    }
}
