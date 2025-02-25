using AutoMapper;
using MediatR;
using Rira_Task.Application.Contracts.Persistence;
using Rira_Task.Application.DTOs.Person.Validators;
using Rira_Task.Application.Features.Person.Requests.Commands;
using Rira_Task.Application.Responses;



namespace Rira_Task.Application.Features.Person.Handlers.Commands
{
    public class CreatePersonCommandHandler : IRequestHandler<CreatePersonCommand, BaseCommandResponse>
    {

        private readonly IMapper _mapper;
        private readonly IPersonRepository _personRepository;

        public CreatePersonCommandHandler(IMapper mapper, IPersonRepository personRepository)
        {
            _mapper = mapper;
            _personRepository = personRepository;
        }
        public async Task<BaseCommandResponse> Handle(CreatePersonCommand request, CancellationToken cancellationToken)
        {
            var Responses = new Application.Responses.BaseCommandResponse();

            var validator = new CreatePersonValidator();

            var Result = await validator.ValidateAsync(request.CreatePersonDto);


            if (Result.IsValid == false)
                throw new Application.Exceptions.ValidationException(Result);


            var R =(await _personRepository.Add(_mapper.Map<Domain.Person>(request.CreatePersonDto))).ID;
          
            Responses.Success = true;
            Responses.Message = "Creation Succesedfull";
            Responses.ID = R;

            return Responses;

        }

    }
    

    
}
