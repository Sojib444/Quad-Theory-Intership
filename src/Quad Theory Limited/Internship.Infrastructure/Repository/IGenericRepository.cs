namespace Internship.Infrastructure.Repository
{
	public interface IGenericRepository<T> where T : class
	{
		Task Add(T enity);
		Task Delete(Guid Id);
		T Update(Guid Id);
		T GetAll(T entity);
		T Get(Guid Id);
	}
}
