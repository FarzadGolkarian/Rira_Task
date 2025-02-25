using Microsoft.EntityFrameworkCore;
using Rira_Task.Application.Contracts.Persistence;
using Rira_Task.Domain;

namespace Rira_Task.Persistence.Repositories
{
    public class PersonRepository : GenericRepository<Person>, IPersonRepository
    {
        private readonly Rira_TaskDbContext _dbContext;
        public PersonRepository(Rira_TaskDbContext context) : base(context)
        {
            _dbContext = context;
        }


        public async Task<List<Person>> GetPersonList()
        {

            return await _dbContext.Set<Person>().ToListAsync();
            

        }

    }
}
