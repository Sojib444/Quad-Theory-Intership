using Autofac;
using Internship.Infrastructure.Context;
using Internship.Infrastructure.Repository.EntityRepoository;
using Internship.Infrastructure.UnitOfWork;

namespace Internship.Infrastructure.Muodule
{
	public class InfrastructureModule : Module
	{
		public InfrastructureModule(IApplicationDbContxt applicationDbContxt)
		{

		}
		protected override void Load(ContainerBuilder builder)
		{
			builder.RegisterType<UnitofWork>()
				.As<IUnitofWork>();

			builder.RegisterType<ClassTableRepository>()
				.As<IClassTebleRepository>();

			builder.RegisterType<StudentTablerepository>()
				.As<IStudentrepository>();


			base.Load(builder);
		}
	}
}
