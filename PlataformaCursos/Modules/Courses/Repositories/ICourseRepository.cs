using PlataformaCursos.Modules.Courses.Entities;

namespace PlataformaCursos.Modules.Courses.Repositories
{
    public interface ICourseRepository
    {
        Task<List<Course>> GetAllAsync();
        Task<Course?> GetByIdAsync(Guid id);
        Task AddAsync(Course category);
        Task <Course> UpdateAsync(Course category);
        Task DeleteAsync(Course category);
      
    }
}
