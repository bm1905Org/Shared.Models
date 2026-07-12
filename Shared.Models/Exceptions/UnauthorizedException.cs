using System.Runtime.Serialization;

namespace Shared.Models.Exceptions;

/// <summary>
/// Custom API exception.
/// </summary>
[Serializable]
public class UnauthorizedException : Exception
{
    public UnauthorizedException() { }

    public UnauthorizedException(Type type) 
        : base($"{type} is missing") { }

    public UnauthorizedException(string message) 
        : base(message) { }

    public UnauthorizedException(string message, Exception innerException) 
        : base(message, innerException) { }

    public UnauthorizedException(string message, string stackTrace) 
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
    protected UnauthorizedException(SerializationInfo info, StreamingContext context)
        : base(info, context)
    {
    }
}