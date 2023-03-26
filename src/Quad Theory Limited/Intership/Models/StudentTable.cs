using Autofac;
using AutoMapper;
using Internship.Infrastructure.DTO;
using Internship.Infrastructure.Service;
using System.ComponentModel.DataAnnotations;

namespace Intership.Models
{
	public class StudentTable:BaseModel
	{
		public IStudentTableService StudentTableService { get; }
		public ILifetimeScope LifetimeScope { get; set; }
		public IMapper Mapper { get; set; }

		public StudentTable()
		{

		}

		public StudentTable(IStudentTableService studentTableService,
			ILifetimeScope lifetimeScope,IMapper mapper)
		{
			StudentTableService = studentTableService;
			LifetimeScope = lifetimeScope;
			LifetimeScope.Resolve<IStudentTableService>();
			Mapper = mapper;
		}

		public void ResolveDependency(ILifetimeScope scope)
		{
			base.ResolveDependency(scope);

		}

		[Required]
		public string? Name { get; set; }
		[Required]
		public DateTime? DOB { get; set; }
		[Required]
		public string? Gender { get; set; }
		[Required]
		public int ClassId { get; set; }

		public void AddStudent(StudentTable studentTable )
		{
			var dStudent = Mapper.Map<DStudentTable>(studentTable);

			StudentTableService.AddStudent(dStudent);
		}
	}
}
