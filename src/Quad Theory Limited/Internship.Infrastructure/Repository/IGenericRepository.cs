using System.Threading.Tasks;

namespace Internship.Infrastructure.Repository
{
	public interface IGenericRepository<T> where T : class
	{
		Task Add(T enity);
		Task Delete(Guid Id);
        Task<T> Update(Guid Id);
        Task<List<T>> GetAll();
        Task<T> Get(Guid Id);
	}
}
