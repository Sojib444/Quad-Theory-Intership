using Autofac;
using AutoMapper;
using Internship.Infrastructure.DTO;
using Internship.Infrastructure.Service;
using System.ComponentModel.DataAnnotations;

namespace Intership.Models
{
	public class StudentTable:BaseModel
	{
		private IStudentTableService _studentTableService { get; set; }
		private IMapper _mapper { get; set; }

		public StudentTable():base()
		{

		}

		public StudentTable(IStudentTableService studentTableService,IMapper mapper)
		{
			_studentTableService = studentTableService;
			_mapper = mapper;
		}

		public override void ResolveDependency(ILifetimeScope scope)
		{
			base.ResolveDependency(scope);
			_studentTableService = _scope.Resolve<IStudentTableService>();
			_mapper = scope.Resolve<IMapper>();
		}

		[Required]
		public string? Name { get; set; }
		[Required]
		public DateTime DateOfBirth { get; set; }
		[Required]
		public string? Gender { get; set; }
		[Required]
		public int ClassId { get; set; }

		public async Task AddStudent(StudentTable studentTable)
		{
			DStudentTable dStudentTable = new DStudentTable();

			var result=_mapper.Map<DStudentTable>(studentTable);

			await _studentTableService.AddStudent(result);
		}
	}
}
