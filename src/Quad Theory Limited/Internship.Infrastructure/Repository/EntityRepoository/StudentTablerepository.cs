using Internship.Infrastructure.Context;
using Internship.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace Internship.Infrastructure.Repository.EntityRepoository
{
	public class StudentTablerepository : GenericRepository<StudentTable>, IStudentrepository
	{
		public StudentTablerepository(IApplicationDbContxt applicationDbContxt):base((DbContext)applicationDbContxt)
		{

		}
	}
}
