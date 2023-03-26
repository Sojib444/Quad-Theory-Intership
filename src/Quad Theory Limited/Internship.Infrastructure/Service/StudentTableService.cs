using Internship.Infrastructure.DTO;
using Internship.Infrastructure.UnitOfWork;

namespace Internship.Infrastructure.Service
{
	public class StudentTableService : IStudentTableService
	{
		private IUnitofWork _unitofWork { get; set; }
	
		public StudentTableService(IUnitofWork unitofWork)
		{
			_unitofWork = unitofWork;
		}

		public Task AddStudent(DStudentTable dStudent)
		{
			_unitofWork.
		}

		public Task DeleteStudent(Guid Id)
		{
			throw new NotImplementedException();
		}

		public Task<DStudentTable> GetStudent(Guid Id)
		{
			throw new NotImplementedException();
		}

		public Task UpdateStudent(Guid Id)
		{
			throw new NotImplementedException();
		}
	}
}
