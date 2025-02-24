using MediatR;
using Rira_Task.Application.DTOs.Person;

namespace Rira_Task.Application.Features.Person.Requests.Commands
{
    public class UpdatePersonCommand : IRequest<Unit>
    {
        public int ID { get; set; }
        public UpdatePersonDto UpdatePersonDto { get; set; }
    }
}
