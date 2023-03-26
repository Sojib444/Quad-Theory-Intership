using System.ComponentModel.DataAnnotations;

namespace Intership.Models
{
	public class ClassTable
	{
		public int ID { get; set; }
		[Required]
		public string? Name { get; set; }
		[Required]
		public string? CreatedDate { get; set; }
		[Required]
		public string? ModificationDate { get; set; }
	}
}
