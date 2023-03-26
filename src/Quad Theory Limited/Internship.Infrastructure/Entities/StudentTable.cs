using System.ComponentModel.DataAnnotations;

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
		public DateTime? DOB { get; set; }
        [Required]
        public DateTime? CreatedDate { get; set; }
        [Required]
        public DateTime? Modificationdate { get; set; }
        [Required]
        public ClassTable? ClassId { get; set; }
    }
}
