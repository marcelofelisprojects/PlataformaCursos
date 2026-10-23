using PlataformaCursos.Modules.Categories.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace PlataformaCursos.Modules.Courses.Entities
{
    [Table("courses")]
    public class Course
    {
        [Key]
        public Guid Id { get; set; }
        public String Name { get; set; }
        public String? FullName { get; set; }
        public String? Description { get; set; }
        public String? ImageFileName { get; set; }
        public String TargetAudience { get; set; }
        public DateTime? AvailableFrom { get; set; }
        public int Workload { get; set; }
        public String Status { get; set; }

        [ForeignKey(nameof(Category))]
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

    }
}
