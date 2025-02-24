using AutoMapper;
using MediatR;
using Rira_Task.Application.Contracts.Persistence;
using Rira_Task.Application.Features.Person.Requests.Commands;
using Rira_Task.Application.Responses;

namespace Rira_Task.Application.Features.Person.Handlers.Commands
{
    public class DeletePersonCommandHandler : IRequestHandler<DeletePersonCommand, BaseCommandResponse>
    {
        private readonly IMapper _mapper;
        private readonly IPersonRepository _personRepository;

        public DeletePersonCommandHandler(IMapper mapper, IPersonRepository personRepository)
        {
            _mapper = mapper;
            _personRepository = personRepository;
        }

        public async Task<BaseCommandResponse> Handle(DeletePersonCommand request, CancellationToken cancellationToken)
        {
            var Responses = new Application.Responses.BaseCommandResponse();

            var _person = await _personRepository.GetAsync(request.ID);
            
            if (_person == null) { 
            throw new Application.Exceptions.NotFoundException(nameof(Person) , request.ID);
            }

            await _personRepository.Delete(_person);

            Responses.Success = true;
            Responses.Message = "Delete Succesedfull";
            

            return Responses;
            
        }
    }
}
