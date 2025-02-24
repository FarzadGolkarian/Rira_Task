using AutoMapper;
using Grpc.Core;
using MediatR;
using Rira_Task.Application.Features.Person.Requests.Queries;
using Rira_Task.Grpc.Protos;


namespace Rira_Task.Grpc.Services
{
    public class PersonService : PersonProtoService.PersonProtoServiceBase
    {
        #region CTOR
        private readonly IMediator _mediator;
        private readonly ILogger<PersonService> _logger;
        private readonly IMapper _mapper;

        public PersonService(IMediator mediator, ILogger<PersonService> logger , IMapper mapper)
        {
            _logger = logger;
            _mediator = mediator;
            _mapper = mapper;
        }
        #endregion

        public override async Task<ProtoPersonDto> GetPerson(PersonRequest request, ServerCallContext context)
        {
            _logger.LogInformation("GetPerson");

            return _mapper.Map<ProtoPersonDto>(await _mediator.Send(new GetPersonRequest { ID = request.ID }));

        }

        public override async Task<Response> CreatePerson(CreatePersonCommand request, ServerCallContext context)
        {
            _logger.LogInformation("CreatePerson");

            return _mapper.Map<Response>(await _mediator.Send(new CreatePersonCommand { CreatePersonDto = request.CreatePersonDto}));
        }

        public override async Task<Response> UpdatePerson(UpdatePersonCommand request, ServerCallContext context)
        {
            _logger.LogInformation("UpdatePerson");

            return _mapper.Map<Response>(await _mediator.Send(new UpdatePersonCommand { UpdatePersonDto = request.UpdatePersonDto, ID = request.ID }));
        }

        public override async Task<Response> DeletePerson(DeletePersonCommand request, ServerCallContext context)
        {
            _logger.LogInformation("DeletePerson");
            return _mapper.Map<Response>(await _mediator.Send(new DeletePersonCommand { ID = request.ID }));
        }
    }
}
