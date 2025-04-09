namespace TrackAndGo.Application.Abstractions
{
    public interface IGenericRepository<T> where T : class
    {
        //create methods
        Task AddAsync(T entity, CancellationToken cancellationToken = default);
        Task AddRangeAsync(IEnumerable<T> entities, CancellationToken cancellationToken = default);

        //delete methods
        Task RemoveAsync(int id, CancellationToken cancellationToken = default);
        Task RemoveAsync(T entity, CancellationToken cancellationToken = default);
        Task RemoveRangeAsync(IEnumerable<T> entities, CancellationToken cancellationToken = default);

        //update methods
        Task<T> UpdateAsync(T entity, CancellationToken cancellationToken = default);

        //read methods
        IQueryable<T> GetAll(bool track = false);
        IQueryable<T> GetAllPaged(int pageNumber, int pageSize);
        Task<T> TryGetByIdOrThrowAsync(int id, CancellationToken cancellationToken = default);
        Task<bool> ExistsOrThrowsAsync(int id, CancellationToken cancellationToken = default);
        
        //save methods
        Task SaveAsync(CancellationToken cancellationToken = default);
    }

}
