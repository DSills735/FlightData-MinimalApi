using FlightDataApi.Models;
using FlightDataApi.Services;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
//example: http://localhost:5609/api/flight/
public class FlightsController(IFlightService flightService) : ControllerBase
{
    private readonly IFlightService _flightService = flightService;


[HttpGet]
public ActionResult<List<Flight>> GetAllFlights(int id)
{
        var result = _flightService.GetFlightById(id);

        if (result == null)
        {
            return NotFound();
        }
        return Ok(_flightService.GetAllFlights());
}

[HttpGet("{id}")]
public ActionResult<Flight> GetFlightById(int id)
{
    return Ok(_flightService.GetFlightById(id));
}

[HttpPost]
public ActionResult<Flight> CreateFlight(Flight flight)
{
    return Ok(_flightService.CreateFlight(flight));
}

[HttpPut("{id}")]
public ActionResult<Flight> UpdateFlight(int id, Flight updatedFlight)
{
        var result = _flightService.UpdateFlight(id, updatedFlight);

        if (result == null)
        {
            return NotFound();
        }

        return Ok(_flightService.UpdateFlight(id, updatedFlight));
}

[HttpDelete("{id}")]
public ActionResult<string> DeleteFlight(int id)
{
        var result = _flightService.DeleteFlight(id);

        if (result == null)
        {
            return NotFound();
        }

        return Ok(_flightService.DeleteFlight(id));
}

}

