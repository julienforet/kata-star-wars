using System.Text.Json;

namespace Sgme.Kata.StarWars.Host.Repositories;

public class BasesRepository : IBasesRepository
{
    private readonly List<EmpireBaseJson> bases;
    
    public BasesRepository()
    {
        bases = LoadBases();
    }

    private List<EmpireBaseJson> LoadBases()
    {
        var file = File.OpenRead("Resources/empire_bases_10000.json");
        var result = JsonSerializer.Deserialize<List<EmpireBaseJson>>(file);
        return result ?? new List<EmpireBaseJson>();
    }

    public List<EmpireBaseJson> GetAll()
    {
        return this.bases;
    }

    public EmpireBaseJson? GetByName(string name)
    {
        return this.bases.SingleOrDefault(b => b.BaseName == name);
    }
}