using Internship.Infrastructure.Context;
using Internship.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace Internship.Infrastructure.Repository.EntityRepoository
{
	public class ClassTableRepository : GenericRepository<ClassTable>, IClassTebleRepository
	{
		public ClassTableRepository(IApplicationDbContxt applicationDbContxt) : base((DbContext)applicationDbContxt)
		{

		}
	}
}
