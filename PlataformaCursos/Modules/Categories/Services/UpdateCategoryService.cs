using PlataformaCursos.Modules.Categories.DTOs;
using PlataformaCursos.Modules.Categories.Entities;
using PlataformaCursos.Modules.Categories.Repositories;
using PlataformaCursos.Modules.Modalities.Entities;
using PlataformaCursos.Modules.Modalities.Repositories;
using PlataformaCursos.Shared.Exceptions;

namespace PlataformaCursos.Modules.Categories.Services
{
    public class UpdateCategoryService
    {
        private readonly ICategoryRepository _repository;
        private readonly IModalityRepository _modalityRepository;

        public UpdateCategoryService(ICategoryRepository repository, IModalityRepository modalityRepository)
        {
            _repository = repository;
            _modalityRepository = modalityRepository;
        }


        public async Task<Category> Execute(Guid id, UpdateCategoryDTO category)
        {

            Category? categoryExists = await _repository.GetByIdAsync(id);

            if (categoryExists == null)
            {
                throw new NotFoundException($"Categoria não encontrada");
            }

            categoryExists.Name = category.Name;

            Modality? modalityExists = await _modalityRepository.GetByIdAsync(category.ModalityId);

            if (modalityExists == null)
            {
                throw new NotFoundException($"Modalidade não encontrada");
            }


            categoryExists.ModalityId = category.ModalityId;

            return await _repository.UpdateAsync(categoryExists);      


        }

    }
}
