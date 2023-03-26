using AutoMapper;
using Internship.Infrastructure.DTO;
using Intership.Models;

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
