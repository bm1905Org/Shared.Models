namespace Shared.Models.Resume;

public class ResumeJobRequest
{
    public Guid MasterResumeId { get; set; }
    public string? JobTitle { get; set; }
    public string? CompanyName { get; set; }
    public string JobDescription { get; set; } = string.Empty;
}