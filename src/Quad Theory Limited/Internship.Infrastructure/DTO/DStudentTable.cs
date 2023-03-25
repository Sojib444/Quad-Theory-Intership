using Internship.Infrastructure.Entities;
using System.ComponentModel.DataAnnotations;

namespace Internship.Infrastructure.DTO
{
	public class DStudentTable
	{
		public string? Name { get; set; }
		[Required]
		public DateOnly? DOB { get; set; }
		[Required]
		public DateOnly? CreatedDate { get; set; }
		[Required]
		public DateOnly? Modificationdate { get; set; }
		[Required]
		public ClassTable? ClassId { get; set; }
	}
}
