using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Sgme.Kata.StarWars.Host.Repositories;

namespace Sgme.Kata.StarWars.Host.Controllers;

[ApiController]
[Route("bases")]
public class EmpireBaseController : ControllerBase
{
    private readonly IBasesRepository _basesRepository;
    private readonly ILogger<EmpireBaseController> _logger;
    

    public EmpireBaseController(IBasesRepository basesRepository, ILogger<EmpireBaseController> logger)
    {
        _basesRepository = basesRepository;
        _logger = logger;
    }

    [HttpGet]
    public PaginatedResult<EmpireBaseApi>? Get([FromQuery] int pageNumber = 0)
    {
        var result = new List<EmpireBaseApi>();

        foreach (var empireBase in _basesRepository.GetAll())
        {
            result.Add(new EmpireBaseApi
            {
                Commander = new Commander
                {
                    FirstName = empireBase.CommanderName.Split(' ')[0],
                    LastName = empireBase.CommanderName.Split(' ')[1]
                },
                Coordinates = new GpsCoordinates
                {
                    Latitude = empireBase.Latitude.ToString(),
                    Longitude = empireBase.Longitude.ToString(),
                },
                BaseName = empireBase.BaseName,
                TroopsNumber = empireBase.TroopsNumber,
                PlanetId = empireBase.PlanetId
            });
        }

        return new PaginatedResult<EmpireBaseApi>
        {
            PageNumber = pageNumber,
            PageSize = 50,
            Count = result.Count,
            Results = result.GetRange(pageNumber * 50, 50)
        };
    }

    [HttpGet("{name}")]
    public EmpireBaseApi? GetByName([FromRoute] string name)
    {
        var result = _basesRepository.GetByName(name);
        if (result == null)
        {
            return null;
        }

        return new EmpireBaseApi
        {
            Commander = new Commander
            {
                FirstName = result.CommanderName.Split(' ')[0],
                LastName = result.CommanderName.Split(' ')[1]
            },
            Coordinates = new GpsCoordinates
            {
                Latitude = result.Latitude.ToString(),
                Longitude = result.Longitude.ToString(),
            },
            BaseName = result.BaseName,
            TroopsNumber = result.TroopsNumber,
            PlanetId = result.PlanetId
        };
    }
}