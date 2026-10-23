using Microsoft.EntityFrameworkCore;
using PlataformaCursos.Infrastructure.Data;
using PlataformaCursos.Modules.Courses.Entities;
using PlataformaCursos.Modules.Courses.Repositories;

public class CourseRepository : ICourseRepository
{
    private readonly AppDbContext _context;

    public CourseRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<Course>> GetAllAsync()
    {
        return await _context.Courses.Include(x => x.Category).ToListAsync();
    }

    public async Task<Course?> GetByIdAsync(Guid id)
    {
        return await _context.Courses.Include(x => x.Category).FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task AddAsync(Course course)
    {
        _context.Courses.Add(course);
        await _context.SaveChangesAsync();
    }

    public async Task<Course> UpdateAsync(Course course)
    {
        _context.Courses.Update(course);

        await _context.SaveChangesAsync();

        await _context.Entry(course).ReloadAsync();

        return course;
    }

    public async Task DeleteAsync(Course course)
    {
        _context.Courses.Remove(course);
        await _context.SaveChangesAsync();
    }
}