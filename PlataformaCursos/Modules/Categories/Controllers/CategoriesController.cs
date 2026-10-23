using Microsoft.AspNetCore.Mvc;
using PlataformaCursos.Modules.Categories.DTOs;
using PlataformaCursos.Modules.Categories.Entities;
using PlataformaCursos.Modules.Categories.Services;

namespace PlataformaCursos.Controllers;

[ApiController]
[Route("api/categories")]
public class CategoriesController : ControllerBase
{
    private readonly CreateCategoryService _createCategoryService;
    private readonly GetAllCategoriesService _getAllCategoriesService;
    private readonly GetCategoryService _getCategoryService;
    private readonly UpdateCategoryService _updateCategoryService;
    private readonly DeleteCategoryService _deleteCategoryService;

    public CategoriesController(CreateCategoryService createCategoryService, GetAllCategoriesService getAllCategoriesService, GetCategoryService getCategoryService, DeleteCategoryService deleteCategoryService, UpdateCategoryService updateCategoryService)
    {
        _createCategoryService = createCategoryService;
        _getAllCategoriesService = getAllCategoriesService;
        _getCategoryService = getCategoryService;
        _updateCategoryService = updateCategoryService;
        _deleteCategoryService = deleteCategoryService;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var categories = await _getAllCategoriesService.Execute();

        return Ok(categories);
    }

    [HttpGet("{id:guid}")]
    public async Task<IActionResult> Get(Guid id)
    {
        var category = await _getCategoryService.Execute(id);

        return Ok(category);
    }

    [HttpPost]
    public async Task<IActionResult> Post(CreateCategoryDTO data)
    {
        Category category = await _createCategoryService.Execute(data);

        return Ok(category);

    }

    [HttpPut("{id:guid}")]
    public async Task<IActionResult> Put(Guid id, UpdateCategoryDTO category)
    {

        Category updatedCategory = await _updateCategoryService.Execute(id, category);

        return Ok(updatedCategory);
    }

    [HttpDelete("{id:guid}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        await _deleteCategoryService.Execute(id);

        return NoContent();
    }
}