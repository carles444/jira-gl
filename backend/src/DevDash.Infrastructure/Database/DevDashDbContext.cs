using DevDash.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DevDash.Infrastructure.Database;

public class DevDashDbContext(DbContextOptions<DevDashDbContext> options) : DbContext(options)
{
    public DbSet<Project> Projects => Set<Project>();
    public DbSet<ProjectTask> Tasks => Set<ProjectTask>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(DevDashDbContext).Assembly);
    }
}