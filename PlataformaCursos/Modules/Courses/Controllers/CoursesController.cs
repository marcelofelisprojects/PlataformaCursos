using Microsoft.AspNetCore.Mvc;
using PlataformaCursos.Modules.Courses.DTOs;
using PlataformaCursos.Modules.Courses.Entities;
using PlataformaCursos.Modules.Courses.Services;

namespace PlataformaCursos.Controllers;

[ApiController]
[Route("api/courses")]
public class CoursesController : ControllerBase
{
    private readonly CreateCourseService _createCourseService;
    private readonly GetAllCoursesService _getAllCoursesService;
    private readonly GetCourseService _getCourseService;
    private readonly UpdateCourseService _updateCourseService;
    private readonly DeleteCourseService _deleteCourseService;

    public CoursesController(CreateCourseService createCourseService, GetAllCoursesService getAllCoursesService, GetCourseService getCourseService, DeleteCourseService deleteCourseService, UpdateCourseService updateCourseService)
    {
        _createCourseService = createCourseService;
        _getAllCoursesService = getAllCoursesService;
        _getCourseService = getCourseService;
        _updateCourseService = updateCourseService;
        _deleteCourseService = deleteCourseService;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var courses = await _getAllCoursesService.Execute();

        return Ok(courses);
    }

    [HttpGet("{id:guid}")]
    public async Task<IActionResult> Get(Guid id)
    {
        var course = await _getCourseService.Execute(id);

        return Ok(course);
    }

    [HttpPost]
    public async Task<IActionResult> Post(CreateCourseDTO data)
    {
        Course course = await _createCourseService.Execute(data);

        return Ok(course);

    }

    [HttpPut("{id:guid}")]
    public async Task<IActionResult> Put(Guid id, UpdateCourseDTO course)
    {

        Course updatedCourse = await _updateCourseService.Execute(id, course);

        return Ok(updatedCourse);
    }

    [HttpDelete("{id:guid}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        await _deleteCourseService.Execute(id);

        return NoContent();
    }
}