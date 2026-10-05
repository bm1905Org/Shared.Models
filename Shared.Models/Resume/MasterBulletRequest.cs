using System.ComponentModel.DataAnnotations;

namespace Shared.Models.Resume;

public class MasterBulletRequest
{
    [Required]
    public string OriginalText { get; set; } = string.Empty;

    public string? QuantifiedText { get; set; }

    [MaxLength(500)]
    public string? Skills { get; set; }

    [MaxLength(500)]
    public string? Keywords { get; set; }

    [Range(0, 999.99)]
    public decimal? ImpactScore { get; set; }
}
