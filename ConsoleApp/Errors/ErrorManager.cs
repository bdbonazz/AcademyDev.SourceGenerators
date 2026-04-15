namespace ConsoleApp.Errors;

public static partial class ErrorManager
{
    public static BadRequestException BadRequestError(Exception exception)
    {
        return new BadRequestException(exception);
    }
}