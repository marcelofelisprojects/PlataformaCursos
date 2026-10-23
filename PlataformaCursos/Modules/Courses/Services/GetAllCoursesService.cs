using PlataformaCursos.Modules.Courses.Entities;
using PlataformaCursos.Modules.Courses.Repositories;

namespace PlataformaCursos.Modules.Courses.Services
{
    public class GetAllCoursesService
    {
        private readonly ICourseRepository _repository;

        public GetAllCoursesService(ICourseRepository repository)
        {
            _repository = repository;
        }


        public async Task<List<Course>> Execute()
        {

            List<Course> courses = await _repository.GetAllAsync();

            return courses;
        }

    }
}
