namespace Shared.Models.Resume;

public class QuotaResponse
{
    public string Tier { get; set; } = string.Empty;
    public int GenerationsUsedThisMonth { get; set; }
    public int GenerationsAllowedThisMonth { get; set; }
    public DateTime ResetsAt { get; set; }
}