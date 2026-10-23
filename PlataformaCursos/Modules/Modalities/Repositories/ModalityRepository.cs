using Microsoft.EntityFrameworkCore;
using PlataformaCursos.Infrastructure.Data;
using PlataformaCursos.Modules.Modalities.Entities;
using PlataformaCursos.Modules.Modalities.Repositories;

public class ModalityRepository : IModalityRepository
{
    private readonly AppDbContext _context;

    public ModalityRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<Modality>> GetAllAsync()
    {
        return await _context.Modalities.ToListAsync();
    }

    public async Task<Modality?> GetByIdAsync(Guid id)
    {
        return await _context.Modalities.FindAsync(id);
    }

    public async Task AddAsync(Modality modality)
    {
        _context.Modalities.Add(modality);
        await _context.SaveChangesAsync();
    }

    public async Task<Modality> UpdateAsync(Modality modality)
    {
        _context.Modalities.Update(modality);

        await _context.SaveChangesAsync();

        await _context.Entry(modality).ReloadAsync();

        return modality;
    }

    public async Task DeleteAsync(Modality modality)
    {
        _context.Modalities.Remove(modality);
        await _context.SaveChangesAsync();
    }
}