using PlataformaCursos.Modules.Categories.Entities;
using PlataformaCursos.Modules.Categories.Repositories;
using PlataformaCursos.Modules.Courses.DTOs;
using PlataformaCursos.Modules.Courses.Entities;
using PlataformaCursos.Modules.Courses.Repositories;
using PlataformaCursos.Shared.Exceptions;

namespace PlataformaCursos.Modules.Courses.Services
{
    public class UpdateCourseService
    {
        private readonly ICourseRepository _repository;
        private readonly ICategoryRepository _categoryRepository;

        public UpdateCourseService(ICourseRepository repository, ICategoryRepository categoryRepository)
        {
            _repository = repository;
            _categoryRepository = categoryRepository;
        }


        public async Task<Course> Execute(Guid id, UpdateCourseDTO course)
        {

            Course? courseExists = await _repository.GetByIdAsync(id);

            if (courseExists == null)
            {
                throw new NotFoundException($"Curso não encontrado");
            }

            courseExists.Name = course.Name;

            Category? categoryExists = await _categoryRepository.GetByIdAsync(course.CategoryId);

            if (categoryExists == null)
            {
                throw new NotFoundException($"Categoria não encontrada");
            }

            courseExists.CategoryId = course.CategoryId;

            return await _repository.UpdateAsync(courseExists);      


        }

    }
}
