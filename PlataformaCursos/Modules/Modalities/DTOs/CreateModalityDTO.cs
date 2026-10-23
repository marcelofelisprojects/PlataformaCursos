using System.ComponentModel.DataAnnotations;
namespace PlataformaCursos.Modules.Modalities.DTOs
{
    public class CreateModalityDTO
    {
        [Required(ErrorMessage ="Nome é obrigatório")]
        public String Name { get; set; }

    }
}