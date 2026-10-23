using PlataformaCursos.Modules.Categories.DTOs;
using PlataformaCursos.Modules.Categories.Entities;
using PlataformaCursos.Modules.Categories.Repositories;
using PlataformaCursos.Modules.Modalities.Entities;
using PlataformaCursos.Modules.Modalities.Repositories;
using PlataformaCursos.Shared.Exceptions;

namespace PlataformaCursos.Modules.Categories.Services
{
    public class CreateCategoryService
    {
        private readonly ICategoryRepository _repository;
        private readonly IModalityRepository _modalityRepository;

        public CreateCategoryService(ICategoryRepository repository, IModalityRepository modalityRepository)
        {
            _repository = repository;
            _modalityRepository = modalityRepository;
        }


        public async Task<Category> Execute(CreateCategoryDTO data)
        {

            Modality? modality = await _modalityRepository.GetByIdAsync(data.ModalityId);

            if (modality == null)
            {
                throw new NotFoundException($"Modalidade não encontrada");
            }

            var category = new Category
            {
                Name = data.Name,
                ModalityId = data.ModalityId
            };

            await _repository.AddAsync(category);

            return category;
        }

    }
}
