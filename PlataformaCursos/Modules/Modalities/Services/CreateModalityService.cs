using PlataformaCursos.Modules.Modalities.DTOs;
using PlataformaCursos.Modules.Modalities.Entities;
using PlataformaCursos.Modules.Modalities.Repositories;

namespace PlataformaCursos.Modules.Modalities.Services
{
    public class CreateModalityService
    {
        private readonly IModalityRepository _repository;

        public CreateModalityService(IModalityRepository repository)
        {
            _repository = repository;
        }


        public async Task<Modality> Execute(CreateModalityDTO data)
        {
            var modality = new Modality
            {
                Name = data.Name
            };

            await _repository.AddAsync(modality);

            return modality;
        }

    }
}
