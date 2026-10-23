using PlataformaCursos.Modules.Modalities.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlataformaCursos.Modules.Categories.Entities
{
    [Table("categories")]
    public class Category
    {
        [Key]
        public Guid Id { get; set; }
        public String Name { get; set; }

        [ForeignKey(nameof(Modality))]
        public Guid ModalityId { get; set; }
        public Modality Modality { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

    }
}
