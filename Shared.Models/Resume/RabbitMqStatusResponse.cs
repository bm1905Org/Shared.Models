namespace Shared.Models.Resume;

public class RabbitMqStatusResponse
{
    public bool IsSuccess { get; set; }
    public string Message { get; set; } = string.Empty;
    public DateTime CheckedAt { get; set; }
}
