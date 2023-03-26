using AutoMapper;
using Internship.Infrastructure.DTO;
using Internship.Infrastructure.Entities;
using Internship.Infrastructure.UnitOfWork;

namespace Internship.Infrastructure.Service
{
	public class StudentTableService : IStudentTableService
	{
		private IApplicationUnitofWork _unitofWork { get; set; }
		private IMapper _mapper { get; set; }

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
			studentTable.ClassId = dStudent.ClassId;


			await _unitofWork.Studentrepository.Add(studentTable);

			_unitofWork.SaveChange();
			_unitofWork.Dispose();
		}

		public async Task DeleteStudent(Guid Id)
		{
			await _unitofWork.Studentrepository.Delete(Id);

			_unitofWork.SaveChange();
			_unitofWork.Dispose();
		}

		public async Task<DStudentTable> GetStudent(Guid Id)
		{
            var result = await _unitofWork.Studentrepository.Get(Id);

            var item = _mapper.Map<DStudentTable>(result);

            return item;
        }

		public async Task UpdateStudent(DStudentTable stuedent)
		{
			var result = await _unitofWork.Studentrepository.Update(stuedent.Id);

			result.CreatedDate = DateTime.UtcNow;
			result.Modificationdate = DateTime.UtcNow;
			result.Gender = stuedent.Gender;
			result.Name = stuedent.Name;
			result.DateOfBirth = stuedent.DateOfBirth;
			result.ClassId = stuedent.ClassId;

			_unitofWork.SaveChange();
			_unitofWork.Dispose();
		}

        public async Task<List<DStudentTable>> GetAllStudent()
        {
			var items = await _unitofWork.Studentrepository.GetAll();

			List<DStudentTable> dStudent = new List<DStudentTable>();

			foreach(var item in items)
			{
				var ditem = _mapper.Map<DStudentTable>(item);

				dStudent.Add(ditem);
			}

			return dStudent;
			
        }

    }
}
