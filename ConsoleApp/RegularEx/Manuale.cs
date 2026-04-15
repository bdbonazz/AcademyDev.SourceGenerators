using System.Text.RegularExpressions;

namespace ConsoleApp.RegularEx;

internal class Manuale
{
    public static bool IsValidMobileNumber(string inputMobileNumber)
    {
        string strRegex = @"(^[0-9]{10}$)|(^\+[0-9]{2}\s+[0-9]
                {2}[0-9]{8}$)|(^[0-9]{3}-[0-9]{4}-[0-9]{4}$)";

        Regex re = new(strRegex);

        if (re.IsMatch(inputMobileNumber))
            return (true);
        else
            return (false);
    }
}
