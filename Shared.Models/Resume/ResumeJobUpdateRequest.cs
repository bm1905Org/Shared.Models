namespace Shared.Models.Resume;

public class ResumeJobUpdateRequest
{
    public string? Status { get; set; } // Pending, Queued, Processing, Completed, Failed
    public string? StatusDescription { get; set; }
    public string? TailoredLatex { get; set; }
    public string? PdfPath { get; set; }
    public string? ErrorMessage { get; set; }
}