using System.ComponentModel.DataAnnotations;

namespace Shared.Models.Resume;

public class MasterCertificationRequest
{
    [Required, MaxLength(200)]
    public string Name { get; set; } = string.Empty;

    [MaxLength(200)]
    public string? IssuingOrganization { get; set; }

    public DateOnly? IssueDate { get; set; }

    public DateOnly? ExpiryDate { get; set; }

    [MaxLength(100)]
    public string? CredentialId { get; set; }
}
