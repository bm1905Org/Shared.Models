namespace Shared.Models.Resume;

public class ResumeJobResponse
{
    public Guid ResumeId { get; set; }
    public Guid MasterResumeId { get; set; }
    public string? JobTitle { get; set; }
    public string? CompanyName { get; set; }
    public string JobDescription { get; set; } = string.Empty;
    public string? RefinementPrompt { get; set; }
    public string? TailoredLatex { get; set; }
    public string Status { get; set; } = string.Empty;
    public string? StatusDescription { get; set; }
    public string? PdfPath { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}