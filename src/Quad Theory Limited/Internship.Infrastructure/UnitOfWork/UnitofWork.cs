using Microsoft.EntityFrameworkCore;

namespace Internship.Infrastructure.UnitOfWork
{
	public class UnitofWork : IUnitofWork
	{
		public UnitofWork(DbContext applicationDb)
		{
			ApplicationDb = applicationDb;
		}

		public DbContext ApplicationDb { get; set; }

		public void Dispose()
		{
			ApplicationDb.Dispose();
		}

		public void SaveChange()
		{
			ApplicationDb.SaveChanges();
		}
	}
}
