using Microsoft.EntityFrameworkCore;
using Unitofwork.Models;
using UnitOfWork.Interface;

namespace UnitOfWork.Repos
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected LearnDbContext dbContext;
        internal DbSet<T> DbSet { get; set; }

        public GenericRepository(LearnDbContext learnDb)
        {
            this.dbContext = learnDb;
            this.DbSet = this.dbContext.Set<T>();
        }

        public Task<T> AddAsync(T obj)
        {
            throw new NotImplementedException();
        }

        public Task<T> DeleteAsync(object id)
        {
            throw new NotImplementedException();
        }

        public Task<List<T>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByIdAsync(object id)
        {
            throw new NotImplementedException();
        }

        public Task<T> UpdateAsync(T obj)
        {
            throw new NotImplementedException();
        }
    }
}