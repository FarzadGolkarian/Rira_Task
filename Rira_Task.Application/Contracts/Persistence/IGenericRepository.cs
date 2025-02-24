namespace Rira_Task.Application.Contracts.Persistence
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IReadOnlyList<T>> GetAllAsync(); 
        Task<T> GetAsync(int id);
        Task<T> Add(T Entity);
        Task<bool> Update(T Entity);
        Task<bool> Delete(T Entity);
        Task<bool> IsExist(int id);
    }
}
