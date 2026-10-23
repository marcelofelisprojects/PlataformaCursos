using PlataformaCursos.Modules.Categories.Entities;

namespace PlataformaCursos.Modules.Categories.Repositories
{
    public interface ICategoryRepository
    {
        Task<List<Category>> GetAllAsync();
        Task<Category?> GetByIdAsync(Guid id);
        Task AddAsync(Category category);
        Task <Category> UpdateAsync(Category category);
        Task DeleteAsync(Category category);
      
    }
}
