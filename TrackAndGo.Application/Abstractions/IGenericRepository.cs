namespace TrackAndGo.Application.Abstractions
{
    public interface IGenericRepository<T> where T : class
    {
        Task AddAsync(T entity, CancellationToken cancellationToken = default);
        Task RemoveAsync(int id, CancellationToken cancellationToken = default);
        Task<T> UpdateAsync(T entity, CancellationToken cancellationToken = default);
        IQueryable<T> Read(bool track = false);
        Task<bool> ExistsOrThrowsAsync(int id, CancellationToken cancellationToken = default);
        Task SaveAsync(CancellationToken cancellationToken = default);
    }

}
