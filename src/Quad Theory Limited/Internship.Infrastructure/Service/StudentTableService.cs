using AutoMapper;
using Internship.Infrastructure.DTO;
using Internship.Infrastructure.Entities;
using Internship.Infrastructure.UnitOfWork;

namespace Internship.Infrastructure.Service
{
	public class StudentTableService : IStudentTableService
	{
		private IApplicationUnitofWork _unitofWork { get; set; }
		public IMapper _mapper { get; }

		public StudentTableService(IApplicationUnitofWork unitofWork,IMapper mapper)
		{
			_unitofWork = unitofWork;
			_mapper = mapper;
		}

		public async Task AddStudent(DStudentTable dStudent)
		{
			StudentTable studentTable = new StudentTable();
			studentTable.CreatedDate = DateTime.UtcNow;
			studentTable.Modificationdate = DateTime.UtcNow;
			studentTable.Gender = dStudent.Gender;
			studentTable.Name = dStudent.Name;
			studentTable.DateOfBirth = dStudent.DateOfBirth;
			studentTable.ClassId = (int) dStudent.ClassId;


			await _unitofWork.Studentrepository.Add(studentTable);

			_unitofWork.SaveChange();
			_unitofWork.Dispose();
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
