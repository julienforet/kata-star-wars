namespace Sgme.Kata.StarWars.Host;

public class EmpireBaseApi
{
    public string BaseName { get; set; }

    public Commander Commander { get; set; }

    public int TroopsNumber { get; set; }

    public GpsCoordinates Coordinates { get; set; }
    
    public int PlanetId { get; set; }
}

public class Commander
{
    public string LastName { get; set; }
    public string FirstName { get; set; }
}

public class GpsCoordinates
{
    public string Latitude { get; set; }
    public string Longitude { get; set; }
}