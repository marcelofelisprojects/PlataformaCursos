using PlataformaCursos.Modules.Courses.Entities;
using PlataformaCursos.Modules.Courses.Repositories;
using PlataformaCursos.Shared.Exceptions;

namespace PlataformaCursos.Modules.Courses.Services
{
    public class DeleteCourseService
    {
        private readonly ICourseRepository _repository;

        public DeleteCourseService(ICourseRepository repository)
        {
            _repository = repository;
        }


        public async Task Execute(Guid id)
        {

            Course? course = await _repository.GetByIdAsync(id);

            if(course == null)
            {
                throw new NotFoundException($"Curso não encontrado");
            }

            await _repository.DeleteAsync(course);


        }

    }
}
