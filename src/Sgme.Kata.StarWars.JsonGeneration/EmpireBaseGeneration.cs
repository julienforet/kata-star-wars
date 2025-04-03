namespace Sgme.Kata.StarWars.JsonGeneration;

public class EmpireBaseGeneration
{
    
    public static EmpireBase Generate()
    {
        var random = new Random();

        var result = new EmpireBase
        {
            BaseName = StringGeneration.GenerateSayableString(random.Next(8, 13)).ToFirstUpperInvariant(),
            CommanderName =
                $"{StringGeneration.GenerateSayableString(random.Next(7, 12)).ToUpperInvariant()} {StringGeneration.GenerateSayableString(random.Next(6, 11)).ToFirstUpperInvariant()}",
            Latitude = random.Next(-90,90),
            Longitude = random.Next(-180,180),
            TroopsNumber = random.Next(50, 10000),
            PlanetId = random.Next(1,61)
        };

        return result;
    }
}