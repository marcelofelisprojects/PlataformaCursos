using System.ComponentModel.DataAnnotations;

namespace PlataformaCursos.Modules.Categories.DTOs
{
    public class CreateCategoryDTO
    {
        [Required(ErrorMessage ="Nome é obrigatório")]
        public String Name { get; set; }

        [Required(ErrorMessage = "Modalidade é obrigatório")]
        public Guid ModalityId { get; set; }

    }
}