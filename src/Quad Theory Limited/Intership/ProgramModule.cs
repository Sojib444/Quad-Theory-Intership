using Autofac;
using Internship.Infrastructure.DTO;
using Intership.Models;

namespace Intership
{
	public class ProgramModule:Module
	{
		protected override void Load(ContainerBuilder builder)
		{
			builder.RegisterType<StudentTable>()
				.AsSelf();
            builder.RegisterType<DStudentTable>()
                .AsSelf();

            base.Load(builder);
		}
	}
}
