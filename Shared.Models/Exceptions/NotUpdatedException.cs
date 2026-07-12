using System.Runtime.Serialization;

namespace Shared.Models.Exceptions;

/// <summary>
/// Custom API exception.
/// </summary>
[Serializable]
public class NotUpdatedException : Exception
{
    public NotUpdatedException() { }

    public NotUpdatedException(Type type) 
        : base($"{type} is missing") { }

    public NotUpdatedException(string message) 
        : base(message) { }

    public NotUpdatedException(string message, Exception innerException) 
        : base(message, innerException) { }

    public NotUpdatedException(string message, string stackTrace) 
        : base(message)
    {
        // Note: You generally cannot set the StackTrace property like this.
        // The runtime manages the actual stack trace.
    }

    // Serialization constructor - marked obsolete per Microsoft guidance (SYSLIB0051)
    [Obsolete("This API supports obsolete formatter-based serialization. " +
              "It should not be called or extended by application code.", 
        DiagnosticId = "SYSLIB0051", 
        UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
    protected NotUpdatedException(SerializationInfo info, StreamingContext context)
        : base(info, context)
    {
    }
}
