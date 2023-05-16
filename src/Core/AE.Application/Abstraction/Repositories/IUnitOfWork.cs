using AE.Domain.Entities;

namespace AE.Application.Abstraction.Repositories;

public interface IUnitOfWork : IDisposable
{
    IGenericRepository<T> Repository<T>() where T : BaseAuditableEntity;

    Task<int> SaveAsync(CancellationToken cancellationToken);
    Task<int> SaveAndRemoveCacheAsync(CancellationToken cancellationToken, params string[] cacheKeys);
}