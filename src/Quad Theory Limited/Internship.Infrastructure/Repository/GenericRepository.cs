using Microsoft.EntityFrameworkCore;

namespace Internship.Infrastructure.Repository
{
	public class GenericRepository<T> : IGenericRepository<T> where T : class
	{
		private DbContext _dbContext { get; set; }
		private DbSet<T> _dbSet { get; set; }

		public GenericRepository(DbContext dbContext)
		{
			_dbContext = dbContext;
			_dbSet = _dbContext.Set<T>();

		}

		public async Task Add(T entity)
		{
			await _dbSet.AddAsync(entity);
		}

		public async Task Delete(Guid Id)
		{
			var item = await _dbSet.FindAsync(Id);

			if(item != null)
			{
				_dbSet.Remove(item);
			}
		}

		public async Task<T> Get(Guid Id)
		{
            var item = await _dbSet.FindAsync(Id);

            if (item != null)
            {
                return item;
            }

            return null;
        }

		public async Task<List<T>> GetAll()
		{
			var items=await _dbSet.ToListAsync();

			if(items !=null)
			{
				return items;
			}

			return null;
		}

		public async Task<T> Update(Guid Id)
		{
			var item = await _dbSet.FindAsync(Id);

			if(item != null)
			{
				return item;
			}

			return null;
		}
	}
}
