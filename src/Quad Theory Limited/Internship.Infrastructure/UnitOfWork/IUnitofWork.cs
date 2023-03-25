namespace Internship.Infrastructure.UnitOfWork
{
	public interface IUnitofWork : IDisposable
	{
		void SaveChange();
	}
}
