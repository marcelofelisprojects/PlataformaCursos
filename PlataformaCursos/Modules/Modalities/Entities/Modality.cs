using System.ComponentModel.DataAnnotations.Schema;

namespace PlataformaCursos.Modules.Modalities.Entities
{
    [Table("modalities")]
    public class Modality
    {
        public Guid Id { get; set; }
        public String Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

    }
}
