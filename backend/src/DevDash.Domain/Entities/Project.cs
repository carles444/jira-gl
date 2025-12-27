namespace DevDash.Domain.Entities;

public class Project
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public string? Description { get; set; }
    public ICollection<ProjectTask> Tasks { get; set; } = new List<ProjectTask>();
}