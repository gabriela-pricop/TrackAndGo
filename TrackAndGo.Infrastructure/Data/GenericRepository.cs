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

        public async Task<bool> ExistsOrThrowsAsync(int id, CancellationToken cancellationToken = default)
        {
            var result = await _dbSet.AnyAsync(x => x.Id == id, cancellationToken);
            if (result == false)
            {
                throw new EntityNotFoundException(typeof(T), id);
            }
            return true;
        }

        public IQueryable<T> Read(bool track = false)
        {
            var query = _dbSet.AsQueryable();
            return track ? query : query.AsNoTracking();
        }

        public async Task RemoveAsync(int id, CancellationToken cancellationToken = default)
        {
            var entity = await _dbSet.FirstAsync(x => x.Id == id, cancellationToken);
            _dbSet.Remove(entity);
            await SaveAsync(cancellationToken);
        }

        public async Task SaveAsync(CancellationToken cancellationToken = default)
        {
            await _dbContext.SaveChangesAsync(cancellationToken);
        }

        public async Task<T> UpdateAsync(T entity, CancellationToken cancellationToken = default)
        {
            _dbSet.Update(entity);
            await SaveAsync(cancellationToken);
            return entity;
        }
    }
}
