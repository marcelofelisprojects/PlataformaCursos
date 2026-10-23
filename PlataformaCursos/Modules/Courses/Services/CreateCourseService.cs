using PlataformaCursos.Modules.Categories.Entities;
using PlataformaCursos.Modules.Categories.Repositories;
using PlataformaCursos.Modules.Courses.DTOs;
using PlataformaCursos.Modules.Courses.Entities;
using PlataformaCursos.Modules.Courses.Repositories;
using PlataformaCursos.Shared.Exceptions;

namespace PlataformaCursos.Modules.Courses.Services
{
    public class CreateCourseService
    {
        private readonly ICourseRepository _repository;
        private readonly ICategoryRepository _categoryRepository;

        public CreateCourseService(ICourseRepository repository, ICategoryRepository categoryRepository)
        {
            _repository = repository;
            _categoryRepository = categoryRepository;
        }


        public async Task<Course> Execute(CreateCourseDTO data)
        {

            Category? category = await _categoryRepository.GetByIdAsync(data.CategoryId);

            if (category == null)
            {
                throw new NotFoundException($"Categoria não encontrada");
            }

            var course = new Course
            {
                Name = data.Name,
                FullName = data.FullName,
                Description = data.Description,
                ImageFileName = data.ImageFileName,
                TargetAudience = data.TargetAudience,
                AvailableFrom = data.AvailableFrom,
                Workload = data.Workload,
                Status = data.Status,
                CategoryId = data.CategoryId
            };

            await _repository.AddAsync(course);

            return course;
        }

    }
}
