using System.ComponentModel.DataAnnotations;

namespace Shared.Models.Resume;

public class MasterSkillRequest
{
    [Required, MaxLength(150)]
    public string SkillName { get; set; } = string.Empty;

    [MaxLength(100)]
    public string? Category { get; set; }

    [MaxLength(50)]
    public string? ProficiencyLevel { get; set; }

    [Range(0, 99.9)]
    public decimal? YearsOfExperience { get; set; }
}
