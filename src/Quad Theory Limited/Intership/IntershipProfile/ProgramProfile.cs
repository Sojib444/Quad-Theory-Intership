using AutoMapper;
using Internship.Infrastructure.DTO;
using Internship.Infrastructure.Entities;

namespace Intership.IntershipProfile
{
	public class ProgramProfile:Profile
	{
		public ProgramProfile()
		{
			CreateMap<StudentTable, DStudentTable>().ReverseMap();
		}
	}
}
