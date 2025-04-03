using System.Text.Json;

namespace Sgme.Kata.StarWars.JsonGeneration;

public class Program
{
    static void Main(string[] args)
    {
        int jsonSize = 0;
        var jsonSizeSuccess = args.Length> 0 && int.TryParse(args[0], out jsonSize);
        if (!jsonSizeSuccess)
        {
            Console.WriteLine("First argument should be the json size");
            return;
        }

        var bases = new List<EmpireBase>(jsonSize);
        for (var basePosition = 0; basePosition < jsonSize; basePosition++)
        {
            bases.Add(EmpireBaseGeneration.Generate());
        }

        using (var file = File.Create($"empire_bases_{jsonSize}.json"))
        {
            JsonSerializer.Serialize(file, bases);
        }
    }
}