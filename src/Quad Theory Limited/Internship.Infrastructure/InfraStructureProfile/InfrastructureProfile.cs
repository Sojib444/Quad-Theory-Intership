using AutoMapper;
using Internship.Infrastructure.DTO;
using Internship.Infrastructure.Entities;

namespace Internship.Infrastructure.InfraStructureProfile
{
	public class InfrastructureProfile : Profile
	{
		public InfrastructureProfile()
		{
			CreateMap<DStudentTable,StudentTable>().ReverseMap();
		}
	}
}
