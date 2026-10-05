using System.ComponentModel.DataAnnotations;

namespace Shared.Models.Resume;

public class MasterExperienceRequest
{
    [Required, MaxLength(200)]
    public string CompanyName { get; set; } = string.Empty;

    [Required, MaxLength(200)]
    public string JobTitle { get; set; } = string.Empty;

    [MaxLength(200)]
    public string? Location { get; set; }

    [Required]
    public DateOnly StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public bool IsCurrent { get; set; }

    public string? Description { get; set; }

    public int DisplayOrder { get; set; }
}
