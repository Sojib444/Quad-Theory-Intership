using Internship.Infrastructure.Entities;

namespace Internship.Infrastructure.DTO
{
	public class DStudentTable
	{
		public string? Name { get; set; }
		public DateTime? DateOfBirth { get; set; }
		public string? Gender { get; set; }
		public DateTime? CreatedDate { get; set; }
		public DateTime? Modificationdate { get; set; }
		public int ClassId { get; set; }
	}
}
