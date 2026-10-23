using PlataformaCursos.Modules.Categories.Entities;
using PlataformaCursos.Modules.Categories.Repositories;

namespace PlataformaCursos.Modules.Categories.Services
{
    public class GetAllCategoriesService
    {
        private readonly ICategoryRepository _repository;

        public GetAllCategoriesService(ICategoryRepository repository)
        {
            _repository = repository;
        }


        public async Task<List<Category>> Execute()
        {

            List<Category> categories = await _repository.GetAllAsync();

            return categories;
        }

    }
}
