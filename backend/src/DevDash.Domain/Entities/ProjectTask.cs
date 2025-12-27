namespace DevDash.Domain.Entities;

public class ProjectTask
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public string? Status { get; set; }
    
    public int ProjectId { get; set; }
    public Project Project { get; set; } = null!;
}
