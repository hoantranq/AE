using AE.Domain.Common;

namespace AE.Application.Abstraction.Repositories;

public interface IGenericRepository<T> where T : class, IEntityBase
{
    Task<List<T>> GetAllAsync();
    Task<T> GetByIdAsync(int id);
    Task<T> AddAsync(T entity);
    Task<T> UpdateAsync(T entity);
    Task<T> DeleteAsync(T entity);
}