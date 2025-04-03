namespace Sgme.Kata.StarWars.Host;

public class PaginatedResult<T>
    where T : class
{
    public int PageNumber { get; set; }
    public int PageSize { get; set; }
    public int Count { get; set; }
    public IEnumerable<T>? Results { get; set; }
}