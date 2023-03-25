namespace Internship.Infrastructure.Repository
{
	public class GenericRepository<T> : IGenericRepository<T> where T : class
	{
		public Task Add(T enity)
		{
			throw new NotImplementedException();
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
