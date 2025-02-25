using Rira_Task.Domain;

namespace Rira_Task.Application.Contracts.Persistence
{
    public interface IPersonRepository : IGenericRepository<Person>
    {
        Task<List<Person>> GetPersonList();
    }
}
