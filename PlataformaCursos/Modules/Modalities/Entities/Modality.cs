using PlataformaCursos.Modules.Categories.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlataformaCursos.Modules.Modalities.Entities
{
    [Table("modalities")]
    public class Modality
    {
        [Key]
        public Guid Id { get; set; }
        public String Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public static implicit operator Modality?(Category? v)
        {
            throw new NotImplementedException();
        }
    }
}
