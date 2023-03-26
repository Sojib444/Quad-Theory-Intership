using Internship.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace Internship.Infrastructure.Context
{
	public class ApplicationDbContext : DbContext, IApplicationDbContxt
	{
		public string ConnetionString { get; }
		public string Assembly { get; }
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options ,
			string ConnetionString,string Assembly) : base(options)
		{
			this.ConnetionString = ConnetionString;
			this.Assembly = Assembly;
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if(!optionsBuilder.IsConfigured)
			{
				optionsBuilder.UseSqlServer(ConnetionString, e => e.MigrationsAssembly(Assembly));
			}
			base.OnConfiguring(optionsBuilder);
		}

		public DbSet<ClassTable> classTables { get; set; }
		public DbSet<StudentTable> studentTables { get; set; }
	}
}
