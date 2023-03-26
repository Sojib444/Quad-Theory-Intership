using Internship.Infrastructure.DTO;

namespace Internship.Infrastructure.Service
{
	public interface IStudentTableService
	{
		Task AddStudent(DStudentTable dStudent);
		Task<DStudentTable> GetStudent(Guid Id);
		Task UpdateStudent(Guid Id);
		Task DeleteStudent(Guid Id);
	}
}
