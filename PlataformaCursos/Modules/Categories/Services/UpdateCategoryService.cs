using PlataformaCursos.Modules.Categories.DTOs;
using PlataformaCursos.Modules.Categories.Entities;
using PlataformaCursos.Modules.Categories.Repositories;
using PlataformaCursos.Shared.Exceptions;

namespace PlataformaCursos.Modules.Categories.Services
{
    public class UpdateCategoryService
    {
        private readonly ICategoryRepository _repository;

        public UpdateCategoryService(ICategoryRepository repository)
        {
            _repository = repository;
        }


        public async Task<Category> Execute(Guid id, UpdateCategoryDTO category)
        {

            Category? categoryExists = await _repository.GetByIdAsync(id);

            if (categoryExists == null)
            {
                throw new NotFoundException($"Categoria não encontrada");
            }

            categoryExists.Name = category.Name;
            categoryExists.ModalityId = category.ModalityId;

            return await _repository.UpdateAsync(categoryExists);      


        }

    }
}
