using Internship.Infrastructure.DTO;

namespace Internship.Infrastructure.Service
{
	public interface IStudentTableService
	{
		Task AddStudent(DStudentTable dStudent);
		Task<DStudentTable> GetStudent(Guid Id);
		Task<List<DStudentTable>> GetAllStudent();
        Task UpdateStudent(DStudentTable stuedent);
		Task DeleteStudent(Guid Id);
	}
}
