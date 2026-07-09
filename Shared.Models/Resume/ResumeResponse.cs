namespace Shared.Models.Resume;

public class ResumeResponse
{
    public int ResumeId { get; set; }
    public string JobTitle { get; set; } = string.Empty;
    public string CompanyName { get; set; } = string.Empty;
    public string JobDescription { get; set; } = string.Empty;
    public string? TailoredLatex { get; set; }
    public int Status { get; set; }
    public string? StatusDescription { get; set; }
    public string? PdfPath { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}
