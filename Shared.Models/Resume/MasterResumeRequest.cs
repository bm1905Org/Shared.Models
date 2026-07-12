namespace Shared.Models.Resume;

public class MasterResumeRequest
{
    public string ProfileName { get; set; } = string.Empty;
    public string TargetRegion { get; set; } = string.Empty;
    public string Format { get; set; } = string.Empty; // PlainText, LaTeX
    public string Content { get; set; } = string.Empty;
}