using Rira_Task.Application.DTOs.Person;
using Rira_Task.Domain;

namespace Rira_Task.Application.Contracts.Persistence
{
    public interface IPersonRepository : IGenericRepository<Person>
    {
        Task<List<PersonDto>> GetPersonList();
    }
}
