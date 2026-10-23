using PlataformaCursos.Modules.Categories.Entities;
using PlataformaCursos.Modules.Categories.Repositories;
using PlataformaCursos.Shared.Exceptions;

namespace PlataformaCursos.Modules.Categories.Services
{
    public class DeleteCategoryService
    {
        private readonly ICategoryRepository _repository;

        public DeleteCategoryService(ICategoryRepository repository)
        {
            _repository = repository;
        }


        public async Task Execute(Guid id)
        {

            Category? category = await _repository.GetByIdAsync(id);

            if(category == null)
            {
                throw new NotFoundException($"Categoria não encontrada");
            }

            await _repository.DeleteAsync(category);


        }

    }
}
