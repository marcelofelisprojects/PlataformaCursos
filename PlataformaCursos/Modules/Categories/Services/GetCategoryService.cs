using PlataformaCursos.Modules.Categories.Entities;
using PlataformaCursos.Modules.Categories.Repositories;
using PlataformaCursos.Shared.Exceptions;

namespace PlataformaCursos.Modules.Categories.Services
{
    public class GetCategoryService
    {
        private readonly ICategoryRepository _repository;

        public GetCategoryService(ICategoryRepository repository)
        {
            _repository = repository;
        }


        public async Task<Category> Execute(Guid id)
        {

            Category? category = await _repository.GetByIdAsync(id);

            if (category == null)
            {
                throw new NotFoundException($"Categoria não encontrada");
            }

            return category;


        }

    }
}
