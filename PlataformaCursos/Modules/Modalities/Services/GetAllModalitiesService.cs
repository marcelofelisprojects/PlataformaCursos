using PlataformaCursos.Modules.Modalities.Entities;
using PlataformaCursos.Modules.Modalities.Repositories;

namespace PlataformaCursos.Modules.Modalities.Services
{
    public class GetAllModalitiesService
    {
        private readonly IModalityRepository _repository;

        public GetAllModalitiesService(IModalityRepository repository)
        {
            _repository = repository;
        }


        public async Task<List<Modality>> Execute()
        {

            List<Modality> modalities = await _repository.GetAllAsync();

            return modalities;
        }

    }
}
