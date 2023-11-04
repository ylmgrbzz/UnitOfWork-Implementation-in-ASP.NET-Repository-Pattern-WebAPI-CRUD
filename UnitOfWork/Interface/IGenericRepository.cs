namespace UnitOfWork.Interface
{
    public interface IGenericRepository<T> where T : class
    {
        Task<List<T>> GetAllAsync();

        Task<T> GetByIdAsync(object id);

        Task<T> AddAsync(T obj);

        Task<T> UpdateAsync(T obj);

        Task<T> DeleteAsync(object id);
    }
}