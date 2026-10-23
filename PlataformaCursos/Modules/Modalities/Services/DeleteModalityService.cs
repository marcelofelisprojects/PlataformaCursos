using PlataformaCursos.Modules.Modalities.DTOs;
using PlataformaCursos.Modules.Modalities.Entities;
using PlataformaCursos.Modules.Modalities.Repositories;
using PlataformaCursos.Shared.Exceptions;

namespace PlataformaCursos.Modules.Modalities.Services
{
    public class DeleteModalityService
    {
        private readonly IModalityRepository _repository;

        public DeleteModalityService(IModalityRepository repository)
        {
            _repository = repository;
        }


        public async Task Execute(Guid id)
        {

            Modality? modality = await _repository.GetByIdAsync(id);

            if(modality == null)
            {
                throw new NotFoundException($"Modalidade não encontrada");
            }

            await _repository.DeleteAsync(modality);


        }

    }
}
