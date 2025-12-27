using DevDash.Domain.Entities;
using DevDash.Infrastructure.Database;

namespace DevDash.Api.GraphQL;

public class Query
{
    [UseProjection]
    [UseFiltering]
    [UseSorting]
    public IQueryable<Project> GetProjects(DevDashDbContext context) 
        => context.Projects;

    [UseProjection]
    [UseFiltering]
    [UseSorting]
    public IQueryable<ProjectTask> GetTasks(DevDashDbContext context) 
        => context.Tasks;
}