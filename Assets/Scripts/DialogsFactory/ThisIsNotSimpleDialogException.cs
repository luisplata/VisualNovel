using System;
using System.Runtime.Serialization;

[Serializable]
internal class ThisIsNotSimpleDialogException : Exception
{
    public ThisIsNotSimpleDialogException()
    {
    }

    public ThisIsNotSimpleDialogException(string message) : base(message)
    {
    }

    public ThisIsNotSimpleDialogException(string message, Exception innerException) : base(message, innerException)
    {
    }

    protected ThisIsNotSimpleDialogException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}