using Microsoft.EntityFrameworkCore;
using PlataformaCursos.Modules.Modalities.Entities;

namespace PlataformaCursos.Infrastructure.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<Modality> Modalities { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Modality>()
            .Property(x => x.Id)
            .HasDefaultValueSql("gen_random_uuid()");

        modelBuilder.Entity<Modality>()
            .Property(x => x.CreatedAt)
            .HasDefaultValueSql("CURRENT_TIMESTAMP");

        modelBuilder.Entity<Modality>()
            .Property(x => x.UpdatedAt)
            .HasDefaultValueSql("CURRENT_TIMESTAMP");
    }
}