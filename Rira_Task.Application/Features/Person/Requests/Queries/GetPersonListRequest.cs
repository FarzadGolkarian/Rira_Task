using MediatR;
using Rira_Task.Application.DTOs.Person;

namespace Rira_Task.Application.Features.Person.Requests.Queries
{
    public class GetPersonListRequest : IRequest<List<PersonListDto>>
    {
    }
}
