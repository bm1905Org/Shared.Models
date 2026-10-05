using System.ComponentModel.DataAnnotations;

namespace Shared.Models.Resume;

public class MasterEducationRequest
{
    [Required, MaxLength(200)]
    public string Institution { get; set; } = string.Empty;

    [MaxLength(200)]
    public string? Degree { get; set; }

    [MaxLength(200)]
    public string? FieldOfStudy { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    [MaxLength(50)]
    public string? Grade { get; set; }

    public string? Description { get; set; }
}
