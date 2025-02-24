using AutoMapper;
using MediatR;
using Rira_Task.Application.Contracts.Persistence;
using Rira_Task.Application.DTOs.Person;
using Rira_Task.Application.Features.Person.Requests.Queries;

namespace Rira_Task.Application.Features.Person.Handlers.Queries
{
    public class GetPersonRequestHandler : IRequestHandler<GetPersonRequest, PersonDto>
    {
        private readonly IMapper _mapper;
        private readonly IPersonRepository _personRepository;

        public GetPersonRequestHandler( IMapper mapper , IPersonRepository personRepository)
        {
            _mapper = mapper;
            _personRepository = personRepository; 
        }

        public async Task<PersonDto> Handle(GetPersonRequest request, CancellationToken cancellationToken)
        {
            return _mapper.Map<PersonDto>(await _personRepository.GetAsync(request.ID));
        }
    }
}
