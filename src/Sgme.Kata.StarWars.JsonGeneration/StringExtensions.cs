namespace Sgme.Kata.StarWars.JsonGeneration;

public static class StringExtensions
{
    public static string ToFirstUpperInvariant(this string source)
    {
        return source.Substring(0, 1).ToUpperInvariant() + source.Substring(1, source.Length - 1).ToLowerInvariant();
    }
}