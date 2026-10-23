using System.ComponentModel.DataAnnotations;

namespace PlataformaCursos.Modules.Courses.DTOs
{
    public class UpdateCourseDTO
    {
        
        public String Name { get; set; }

        public String FullName { get; set; }

        public String Description { get; set; }
        public String ImageFileName { get; set; }

        public String TargetAudience { get; set; }

        public DateTime AvailableFrom { get; set; }

        public int Workload { get; set; }

        public String Status { get; set; }

        public Guid CategoryId { get; set; }

    }
}