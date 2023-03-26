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

		public Task Delete(Guid Id)
		{
			throw new NotImplementedException();
		}

		public T Get(Guid Id)
		{
			throw new NotImplementedException();
		}

		public T GetAll(T entity)
		{
			throw new NotImplementedException();
		}

		public T Update(Guid Id)
		{
			throw new NotImplementedException();
		}
	}
}
