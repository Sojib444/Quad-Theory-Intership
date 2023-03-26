using Autofac;
using Intership.Models;

namespace Intership
{
	public class ProgramModule:Module
	{
		protected override void Load(ContainerBuilder builder)
		{
			builder.RegisterType<StudentTable>()
				.AsSelf();
				
			base.Load(builder);
		}
	}
}
