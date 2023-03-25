using Internship.Infrastructure.Repository.EntityRepoository;
using Microsoft.EntityFrameworkCore;

namespace Internship.Infrastructure.UnitOfWork
{
	public class UnitofWork : IUnitofWork
	{
		public UnitofWork(DbContext applicationDb,
			IClassTebleRepository classTebleRepository,
			IStudentrepository studentrepository)
		{
			ApplicationDb = applicationDb;
			ClassTebleRepository = classTebleRepository;
			Studentrepository = studentrepository;
		}

		public DbContext ApplicationDb { get; }
		public IClassTebleRepository ClassTebleRepository { get; }
		public IStudentrepository Studentrepository { get; }

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
