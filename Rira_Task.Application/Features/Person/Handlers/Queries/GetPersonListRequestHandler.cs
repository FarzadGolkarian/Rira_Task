using AutoMapper;
using MediatR;
using Rira_Task.Application.Contracts.Persistence;
using Rira_Task.Application.DTOs.Person;
using Rira_Task.Application.Features.Person.Requests.Queries;

namespace Rira_Task.Application.Features.Person.Handlers.Queries
{

    public class GetPersonListRequestHandler : IRequestHandler<GetPersonListRequest, List<PersonListDto>>
    {
        private readonly IMapper _mapper;
        private readonly IPersonRepository _personRepository;

        public GetPersonListRequestHandler(IMapper mapper, IPersonRepository personRepository)
        {
            _mapper = mapper;
            _personRepository = personRepository;
        }

        public async Task<List<PersonListDto>> Handle(GetPersonListRequest request, CancellationToken cancellationToken)
        {
            return _mapper.Map<List<PersonListDto>>(await _personRepository.GetPersonList());
        }
    }

}
