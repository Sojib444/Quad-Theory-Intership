using Internship.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace Internship.Infrastructure.Context
{
	public interface IApplicationDbContxt
	{
		DbSet<ClassTable> classTables { get; set; }
		DbSet<StudentTable> studentTables { get; set; }
	}
}
