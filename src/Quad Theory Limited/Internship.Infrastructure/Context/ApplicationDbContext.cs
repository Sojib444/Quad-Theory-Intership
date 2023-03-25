using Internship.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace Internship.Infrastructure.Context
{
	public class ApplicationDbContext : DbContext, IApplicationDbContxt
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{

		}
		public DbSet<ClassTable> classTables { get; set; }
		public DbSet<StudentTable> studentTables { get; set; }
	}
}
