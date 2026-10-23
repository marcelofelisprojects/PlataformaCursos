using Microsoft.AspNetCore.Mvc;
using PlataformaCursos.Modules.Modalities.Entities;
using PlataformaCursos.Modules.Modalities.Repositories;

namespace PlataformaCursos.Controllers;

[ApiController]
[Route("api/modalities")]
public class ModalitiesController : ControllerBase
{
    private readonly IModalityRepository _repository;

    public ModalitiesController(IModalityRepository repository)
    {
        _repository = repository;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var modalities = await _repository.GetAllAsync();

        return Ok(modalities);
    }

    [HttpGet("{id:guid}")]
    public async Task<IActionResult> Get(Guid id)
    {
        var modality = await _repository.GetByIdAsync(id);

        if (modality == null)
            return NotFound();

        return Ok(modality);
    }

    [HttpPost]
    public async Task<IActionResult> Post(Modality modality)
    {
        await _repository.AddAsync(modality);

        return CreatedAtAction(
            nameof(Get),
            new { id = modality.Id },
            modality);
    }

    [HttpPut("{id:guid}")]
    public async Task<IActionResult> Put(Guid id, Modality modality)
    {
        if (id != modality.Id)
            return BadRequest();

        var existing = await _repository.GetByIdAsync(id);

        if (existing == null)
            return NotFound();

        await _repository.UpdateAsync(modality);

        return NoContent();
    }

    [HttpDelete("{id:guid}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var modality = await _repository.GetByIdAsync(id);

        if (modality == null)
            return NotFound();

        await _repository.DeleteAsync(modality);

        return NoContent();
    }
}