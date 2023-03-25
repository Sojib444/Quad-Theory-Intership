using System.ComponentModel.DataAnnotations;

namespace Internship.Infrastructure.Entities
{
    public class StudentTable
    {
        public Guid Id { get; set; }
        [Required]
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
