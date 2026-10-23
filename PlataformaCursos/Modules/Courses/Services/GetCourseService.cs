using PlataformaCursos.Modules.Courses.Entities;
using PlataformaCursos.Modules.Courses.Repositories;
using PlataformaCursos.Shared.Exceptions;

namespace PlataformaCursos.Modules.Courses.Services
{
    public class GetCourseService
    {
        private readonly ICourseRepository _repository;

        public GetCourseService(ICourseRepository repository)
        {
            _repository = repository;
        }


        public async Task<Course> Execute(Guid id)
        {

            Course? course = await _repository.GetByIdAsync(id);

            if (course == null)
            {
                throw new NotFoundException($"Curso não encontrado");
            }

            return course;


        }

    }
}
