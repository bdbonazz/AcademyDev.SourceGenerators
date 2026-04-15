namespace SourceGenerator.Utils;

internal static class ExtensionMethod
{
    public static T GetLast<T>(this T[] data)
    {
        return data[data.Length - 1];
    }
}
