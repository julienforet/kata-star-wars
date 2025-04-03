namespace Sgme.Kata.StarWars.Host.Repositories;

public interface IBasesRepository
{
    public List<EmpireBaseJson> GetAll();

    public EmpireBaseJson? GetByName(string name);
}