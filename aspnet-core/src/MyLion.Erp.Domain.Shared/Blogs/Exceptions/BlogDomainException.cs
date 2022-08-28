using System.Runtime.Serialization;
using Microsoft.Extensions.Logging;

namespace MyLion.Erp.Blogs.Exceptions;

public class BlogDomainException : UserFriendlyException
{
    public BlogDomainException(string message, string code = null, string details = null, Exception innerException = null, LogLevel logLevel = LogLevel.Warning) : base(message, code, details, innerException, logLevel)
    {
    }

    public BlogDomainException(SerializationInfo serializationInfo, StreamingContext context) : base(serializationInfo, context)
    {
    }
}