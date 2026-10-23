using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlataformaCursos.Modules.Courses.DTOs
{
    public class CreateCourseDTO
    {

        [Required(ErrorMessage = "Nome breve é obrigatório")]
        public String Name { get; set; }

        [Required(ErrorMessage = "Nome completo é obrigatório")]
        public String FullName { get; set; }

        [Required(ErrorMessage = "Descrição é obrigatória")]
        public String Description { get; set; }
        public String ImageFileName { get; set; }

        [Required(ErrorMessage = "Público-alvo é obrigatório")]
        public String TargetAudience { get; set; }

        public DateTime AvailableFrom { get; set; }

        [Required(ErrorMessage = "Carga horária é obrigatória")]
        public int Workload { get; set; }

        [Required(ErrorMessage = "Status é obrigatório")]
        public String Status { get; set; }

        [Required(ErrorMessage = "Categoria é obrigatória")]
        public Guid CategoryId { get; set; }

    }
}