using System;
using System.Runtime.Serialization;

[Serializable]
internal class FindDialogException : Exception
{
    public FindDialogException()
    {
    }

    public FindDialogException(string message) : base(message)
    {
    }

    public FindDialogException(string message, Exception innerException) : base(message, innerException)
    {
    }

    protected FindDialogException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}