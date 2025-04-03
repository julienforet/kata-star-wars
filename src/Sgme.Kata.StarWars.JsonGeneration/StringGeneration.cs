using System.Text;

namespace Sgme.Kata.StarWars.JsonGeneration;

public class StringGeneration
{
    public static char[] Consonants = new[]
        { 'B', 'C', 'D', 'F', 'G', 'H', 'J', 'K', 'L', 'M', 'N', 'P', 'Q', 'R', 'S', 'T', 'V', 'W', 'X', 'Z' };

    public static char[] Vowels = new[] { 'A', 'E', 'I', 'O', 'U', 'Y' };

    public static string GenerateSayableString(int size)
    {
        var random = new Random();
        var result = new StringBuilder();
        var startWithVowel = random.Next(0, 2) == 1;

        for (int letterPosition = 0; letterPosition < size; letterPosition++)
        {
            var listUsed = (startWithVowel && letterPosition % 2 == 0) || (!startWithVowel && letterPosition % 2 == 1)
                ? Vowels
                : Consonants;

            result.Append(listUsed[random.Next(0, listUsed.Length)]);
        }

        return result.ToString();
    }
}