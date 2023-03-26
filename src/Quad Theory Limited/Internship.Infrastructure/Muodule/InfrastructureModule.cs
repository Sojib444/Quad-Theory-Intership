using Autofac;
using Internship.Infrastructure.Context;
using Internship.Infrastructure.DTO;
using Internship.Infrastructure.Repository.EntityRepoository;
using Internship.Infrastructure.Service;
using Internship.Infrastructure.UnitOfWork;

namespace Internship.Infrastructure.Muodule
{
	public class InfrastructureModule : Module
	{
		public InfrastructureModule( string connectionString,string assembly)
		{
			ConnectionString = connectionString;
			Assembly = assembly;
		}

		public string ConnectionString { get;  }
		public string Assembly { get; }

		protected override void Load(ContainerBuilder builder)
		{
			builder.RegisterType<UnitofWork>()
				.As<IUnitofWork>().
				InstancePerLifetimeScope();

			builder.RegisterType<ClassTableRepository>()
				.As<IClassTebleRepository>().
				InstancePerLifetimeScope();

			builder.RegisterType<StudentTablerepository>()
				.As<IStudentrepository>()
				.InstancePerLifetimeScope();

			builder.RegisterType<StudentTableService>()
				.As<IStudentTableService>()
				.InstancePerLifetimeScope();

			builder.RegisterType<DStudentTable>()
				.AsSelf()
				.InstancePerLifetimeScope();

			builder.RegisterType<ApplicationDbContext>()
				.As<IApplicationDbContxt>()
				.WithParameter("ConnetionString", ConnectionString)
				.WithParameter("Assembly", Assembly)
				.InstancePerLifetimeScope();

			builder.RegisterType<ApplicationDbContext>()
				.AsSelf()
				.WithParameter("ConnetionString", ConnectionString)
				.WithParameter("Assembly", Assembly)
				.InstancePerLifetimeScope();


			base.Load(builder);
		}
	}
}
