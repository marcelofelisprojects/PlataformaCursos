using PlataformaCursos.Modules.Modalities.DTOs;
using PlataformaCursos.Modules.Modalities.Entities;
using PlataformaCursos.Modules.Modalities.Repositories;
using PlataformaCursos.Shared.Exceptions;

namespace PlataformaCursos.Modules.Modalities.Services
{
    public class UpdateModalityService
    {
        private readonly IModalityRepository _repository;

        public UpdateModalityService(IModalityRepository repository)
        {
            _repository = repository;
        }


        public async Task<Modality> Execute(Guid id, UpdateModalityDTO modality)
        {

            Modality? modalityExists = await _repository.GetByIdAsync(id);

            if (modalityExists == null)
            {
                throw new NotFoundException($"Modalidade não encontrada");
            }

            modalityExists.Name = modality.Name;

            return await _repository.UpdateAsync(modalityExists);      


        }

    }
}
