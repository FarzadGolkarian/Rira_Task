using AutoMapper;
using MediatR;
using Rira_Task.Application.Contracts.Persistence;
using Rira_Task.Application.DTOs.FoodProgram.Validators;
using Rira_Task.Application.Features.Person.Requests.Commands;

namespace Rira_Task.Application.Features.Person.Handlers.Commands
{
    public class UpdatePersonCommandHandler : IRequestHandler<UpdatePersonCommand, Unit>
    {

        private readonly IMapper _mapper;
        private readonly IPersonRepository _personRepository;

        public UpdatePersonCommandHandler(IMapper mapper, IPersonRepository personRepository)
        {
            _mapper = mapper;
            _personRepository = personRepository;
        }
        public async Task<Unit> Handle(UpdatePersonCommand request, CancellationToken cancellationToken)
        {
            var Validatior = new UpdatePersonValidator();
            var R =await  Validatior.ValidateAsync(request.UpdatePersonDto);

            if (R.IsValid == false)
            {
                throw new Application.Exceptions.ValidationException(R);
            }

            var result = await _personRepository.GetAsync(request.ID);

            if (result == null) { throw new Application.Exceptions.NotFoundException(nameof(result), request.UpdatePersonDto ); }

            _mapper.Map(request.UpdatePersonDto, result);
            await _personRepository.Update(result);
            return Unit.Value;
        }
    }
}
