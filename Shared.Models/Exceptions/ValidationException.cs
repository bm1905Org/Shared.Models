using System.Runtime.Serialization;

namespace Shared.Models.Exceptions;

/// <summary>
/// Custom API exception.
/// </summary>
[Serializable]
public class ValidationException : Exception
{
    public ValidationException() { }

    public ValidationException(Type type) 
        : base($"{type} is missing") { }

    public ValidationException(string message) 
        : base(message) { }

    public ValidationException(string message, Exception innerException) 
        : base(message, innerException) { }

    public ValidationException(string message, string stackTrace) 
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
    protected ValidationException(SerializationInfo info, StreamingContext context)
        : base(info, context)
    {
    }
}