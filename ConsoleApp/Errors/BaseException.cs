namespace ConsoleApp.Errors;

public abstract class BaseException : Exception
{
    public Guid ErrorId { get; }
    public abstract ExceptionCode ExceptionCode { get; }
    public abstract string ExceptionCodeDescription { get; }
    private BaseException(string message, Guid? errorId, Exception? innerException) : base(message, innerException)
    {
        ErrorId = errorId ?? Guid.NewGuid();
    }
    public BaseException(string message, Guid? errorId) : this(message, errorId, null) { }
    public BaseException(Exception innerException) : this(innerException.Message, null, innerException) { }
}
