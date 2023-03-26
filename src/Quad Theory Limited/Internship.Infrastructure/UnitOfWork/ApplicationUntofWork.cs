using Internship.Infrastructure.Context;
using Internship.Infrastructure.Repository.EntityRepoository;
using Microsoft.EntityFrameworkCore;

namespace Internship.Infrastructure.UnitOfWork
{
	public class ApplicationUntofWork : UnitofWork, IApplicationUnitofWork
	{
		public ApplicationUntofWork(IApplicationDbContxt dbContxt,
			IStudentrepository  studentrepository,
			IClassTebleRepository classTebleRepository) : base((DbContext)dbContxt)
		{
			Studentrepository = studentrepository;
			ClassTebleRepository = classTebleRepository;
		}

		public IStudentrepository Studentrepository { get; set; }
		public IClassTebleRepository ClassTebleRepository { get; set; }
	}
}
