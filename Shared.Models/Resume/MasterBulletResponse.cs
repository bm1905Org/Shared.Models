namespace Shared.Models.Resume;

public class MasterBulletResponse
{
    public Guid BulletId { get; set; }
    public Guid ExperienceId { get; set; }
    public string OriginalText { get; set; } = string.Empty;
    public string? QuantifiedText { get; set; }
    public string? Skills { get; set; }
    public string? Keywords { get; set; }
    public decimal? ImpactScore { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}
