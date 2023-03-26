using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Internship.Infrastructure.Entities
{
    public class StudentTable
    {
        public Guid Id { get; set; }
        [Required]
        public string? Name { get; set; }
		[Required]
		public string? Gender { get; set; }
		[Required]
		public DateTime? DateOfBirth { get; set; }
        [Required]
        public DateTime? CreatedDate { get; set; }
        [Required]
        public DateTime? Modificationdate { get; set; }
        [Required]
        [ForeignKey("ClassTable")]
        public int? ClassId { get; set; }
        public ClassTable? ClassTable { get; set; }
    }
}
