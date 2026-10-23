using PlataformaCursos.Modules.Modalities.Entities;

namespace PlataformaCursos.Modules.Modalities.Repositories
{
    public interface IModalityRepository
    {
        Task<List<Modality>> GetAllAsync();
        Task<Modality?> GetByIdAsync(Guid id);
        Task AddAsync(Modality modality);
        Task <Modality>UpdateAsync(Modality modality);
        Task DeleteAsync(Modality modality);
      
    }
}
