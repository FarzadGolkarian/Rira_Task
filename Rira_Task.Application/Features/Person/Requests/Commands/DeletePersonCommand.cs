using MediatR;
using Rira_Task.Application.Responses;

namespace Rira_Task.Application.Features.Person.Requests.Commands
{
    public class DeletePersonCommand : IRequest<BaseCommandResponse>
    {
        public int ID { get; set; }
    }
}
