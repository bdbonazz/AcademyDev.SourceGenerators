using System.ComponentModel;

namespace ConsoleApp.Errors;

public enum ExceptionCode
{
    [Description("BadRequest")]
    E400 = 400,
    [Description("Unauthorized")]
    E401 = 401,
    [Description("Forbidden")]
    E403 = 403,
    [Description("NotFound")]
    E404 = 404,
    //[Description("Teapot")]
    //E418 = 418,
}
