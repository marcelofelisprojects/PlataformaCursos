using Microsoft.AspNetCore.Mvc;
using PlataformaCursos.Modules.Modalities.DTOs;
using PlataformaCursos.Modules.Modalities.Entities;
using PlataformaCursos.Modules.Modalities.Repositories;
using PlataformaCursos.Modules.Modalities.Services;

namespace PlataformaCursos.Controllers;

[ApiController]
[Route("api/modalities")]
public class ModalitiesController : ControllerBase
{
    private readonly CreateModalityService _createModalityService;
    private readonly GetAllModalitiesService _getAllModalitiesService;
    private readonly GetModalityService _getModalityService;
    private readonly UpdateModalityService _updateModalityService;
    private readonly DeleteModalityService _deleteModalityService;

    public ModalitiesController(CreateModalityService createModalityService, GetAllModalitiesService getAllModalitiesService, GetModalityService getModalityService, DeleteModalityService deleteModalityService, UpdateModalityService updateModalityService)
    {
        _createModalityService = createModalityService;
        _getAllModalitiesService = getAllModalitiesService;
        _getModalityService = getModalityService;
        _updateModalityService = updateModalityService;
        _deleteModalityService = deleteModalityService;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var modalities = await _getAllModalitiesService.Execute();

        return Ok(modalities);
    }

    [HttpGet("{id:guid}")]
    public async Task<IActionResult> Get(Guid id)
    {
        var modality = await _getModalityService.Execute(id);

        return Ok(modality);
    }

    [HttpPost]
    public async Task<IActionResult> Post(CreateModalityDTO data)
    {
        Modality modality = await _createModalityService.Execute(data);

        return Ok(modality);

    }

    [HttpPut("{id:guid}")]
    public async Task<IActionResult> Put(Guid id, UpdateModalityDTO modality)
    {

        Modality updatedModality = await _updateModalityService.Execute(id, modality);

        return Ok(updatedModality);
    }

    [HttpDelete("{id:guid}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        await _deleteModalityService.Execute(id);

        return NoContent();
    }
}