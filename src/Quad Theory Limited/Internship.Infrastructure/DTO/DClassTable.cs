using Internship.Infrastructure.Entities;
using System.ComponentModel.DataAnnotations;

namespace Internship.Infrastructure.DTO
{
	public class DClassTable
	{
		public string? Name { get; set; }
		[Required]
		public string? CreatedDate { get; set; }
		[Required]
		public string? ModificationDate { get; set; }
		public List<StudentTable>? Students { get; set; }
	}
}
