namespace Shared.Models.Resume;

public class MasterResumeResponse
{
    public Guid Id { get; set; }
    public string ProfileName { get; set; } = string.Empty;
    public string TargetRegion { get; set; } = string.Empty;
    public string Format { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}