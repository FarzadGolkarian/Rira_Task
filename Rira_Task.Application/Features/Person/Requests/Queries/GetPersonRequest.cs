using MediatR;
using Rira_Task.Application.DTOs.Person;


namespace Rira_Task.Application.Features.Person.Requests.Queries
{
    public class GetPersonRequest : IRequest<PersonDto>
    {
        public int ID { get; set; }
    }
}
