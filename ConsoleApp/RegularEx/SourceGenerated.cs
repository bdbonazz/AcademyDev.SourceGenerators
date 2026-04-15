using System.Text.RegularExpressions;

namespace ConsoleApp.RegularEx;

public sealed partial class SourceGenerated
{
    public static bool IsValidMobileNumber(string inputMobileNumber)
    {
        Regex re = MyRegex();
        if (re.IsMatch(inputMobileNumber))
            return (true);
        else
            return (false);
    }

    [GeneratedRegex(@"(^[0-9]{10}$)|(^\+[0-9]{2}\s+[0-9]
                {2}[0-9]{8}$)|(^[0-9]{3}-[0-9]{4}-[0-9]{4}$)")]
    private static partial Regex MyRegex();
}
