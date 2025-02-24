using MediatR;
using Rira_Task.Application.DTOs.Person;
using Rira_Task.Application.Responses;


namespace Rira_Task.Application.Features.Person.Requests.Commands
{
    public class CreatePersonCommand : IRequest<BaseCommandResponse>
    {
        public CreatePersonDto CreatePersonDto { get; set; }
    }
}
