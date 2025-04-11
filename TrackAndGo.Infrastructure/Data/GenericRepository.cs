using Microsoft.EntityFrameworkCore;
using TrackAndGo.Application.Abstractions;
using TrackAndGo.Application.Exceptions;
using TrackAndGo.Domain.Entities;

namespace TrackAndGo.Infrastructure.Data
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly TrackAndGoDbContext _dbContext;
        private readonly DbSet<T> _dbSet;

        public GenericRepository(TrackAndGoDbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = dbContext.Set<T>();
        }

        public async Task AddAsync(T entity, CancellationToken cancellationToken = default)
        {
            await _dbSet.AddAsync(entity, cancellationToken);
            await SaveAsync(cancellationToken);
        }

        public async Task AddRangeAsync(IEnumerable<T> entities, CancellationToken cancellationToken = default) //check---------------
        {
            await _dbSet.AddRangeAsync(entities, cancellationToken);
            await SaveAsync(cancellationToken);
        }

        public async Task<bool> ExistsOrThrowsAsync(int id, CancellationToken cancellationToken = default)
        {
            var result = await _dbSet.AnyAsync(x => x.Id == id, cancellationToken);
            if (result == false)
            {
                throw new EntityNotFoundException(typeof(T), id);
            }
            return true;
        }

        public IQueryable<T> GetAll(bool track = false)
        {
            var query = _dbSet.AsQueryable();
            return track ? query : query.AsNoTracking();
        }

        public IQueryable<T> GetAllPaged(int pageNumber, int pageSize) 
        {
            if (pageNumber <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(pageNumber), "Page number must be greater than 0.");
            }

            if (pageSize <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(pageSize), "Page size must be greater than 0.");
            }

            return _dbSet 
                .AsNoTracking()
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize);
        }

        public async Task RemoveAsync(int id, CancellationToken cancellationToken = default)
        {
            var entity = await _dbSet.FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
 
            if (entity == null)
            {
                throw new EntityNotFoundException(typeof(T), id);
            }

            _dbSet.Remove(entity);
            await SaveAsync(cancellationToken);
        }

        public async Task RemoveAsync(T entity, CancellationToken cancellationToken = default) 
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity), "The entity to remove cannot be null.");
            }

            _dbSet.Remove(entity);
            await SaveAsync(cancellationToken);
        }

        public async Task RemoveRangeAsync(IEnumerable<T> entities, CancellationToken cancellationToken = default)
        {
            _dbSet.RemoveRange(entities);
            await SaveAsync(cancellationToken);
        }

        public async Task SaveAsync(CancellationToken cancellationToken = default)
        {
            await _dbContext.SaveChangesAsync(cancellationToken);
        }

        public async Task<T> TryGetByIdOrThrowAsync(int id, CancellationToken cancellationToken = default)
        {
            var entity = await _dbSet.FirstOrDefaultAsync(x => x.Id == id, cancellationToken);

            if (entity == null)
            {
                throw new EntityNotFoundException(typeof(T), id);
            }

            return entity;
        }

        public async Task<T> UpdateAsync(T entity, CancellationToken cancellationToken = default)
        {
            _dbSet.Update(entity);
            await SaveAsync(cancellationToken);
            return entity;
        }
    }
}
