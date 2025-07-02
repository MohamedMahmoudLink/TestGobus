using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StationTest.Data;
using StationTest.Models;
namespace StationTest.Controllers
{



 
    [ApiController]
    public class GoBusController : Controller
    {

        private readonly ApplicationDbContext _context;
        private readonly MySqlDbContext _context1;
        public GoBusController(ApplicationDbContext context, MySqlDbContext context1)
        {
            _context = context;
            _context1 = context1;

        }


        [HttpGet]
                          [Route("api/Stations")]

        public async Task<ActionResult<IEnumerable<Station>>> GetStations()
        {
            var stations = await _context.Station
                .FromSqlRaw("EXEC dbo.pro_OnLine_New_Get_Stations @CompanyID = {0}", 1)
                .ToListAsync();

            foreach (var stat in stations) {

                stat.Auth = "Mohamedlink";

            }

            return Ok(stations);
        }


        [HttpGet]
              [Route("api/Mysql/GetAreas")]
        public async Task<IActionResult> GetAreas()
        {
            var areas = await _context1.areas.ToListAsync();
            return Ok(areas);
        }


        [HttpGet]
[Route("api/Mysql/GetPassengersByName")]
public async Task<IActionResult> GetPassengersByName(string name)
{

    if (string.IsNullOrWhiteSpace(name))
        return BadRequest("Name is required");

    var passengers = await _context1.Passenger.Where(p => p.PassengerFullName.StartsWith(name))
        .ToListAsync();

    return Ok(passengers);
}

    }
}
