using System;
using System.Runtime.Serialization;

[Serializable]
internal class FindOptionException : Exception
{
    public FindOptionException()
    {
    }

    public FindOptionException(string message) : base(message)
    {
    }

    public FindOptionException(string message, Exception innerException) : base(message, innerException)
    {
    }

    protected FindOptionException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}