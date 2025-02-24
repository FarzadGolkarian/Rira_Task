using FluentValidation;
using FluentValidation.Results;
using Rira_Task.Application.DTOs.Person;

namespace Rira_Task.Application.DTOs.FoodProgram.Validators
{
    public class UpdatePersonValidator : AbstractValidator<UpdatePersonDto>
    {
        public UpdatePersonValidator()
        {
            Include(new IPersonValidator());
        }

        internal async Task<ValidationResult> ValidateAsync(object updateFoodProgramDto)
        {
            throw new NotImplementedException();
        }
    }
}
