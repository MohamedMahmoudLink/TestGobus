using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using StationTest.Data;
using StationTest.Hubs;
using StationTest.Models;
namespace StationTest.Controllers
{



    [Route("api/[controller]")]
    [ApiController]
    public class GoBusController : Controller
    {
        private readonly IHubContext<PassengerHub> _hubContext;
        private readonly ApplicationDbContext _context;
        private readonly MySqlDbContext _context1;

   
        public GoBusController(ApplicationDbContext context, MySqlDbContext context1, IHubContext<PassengerHub> hubContext)
        {
            _context = context;
            _context1 = context1;
            _hubContext = hubContext;


        }



        [HttpGet]
      


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
              [Route("Mysql/GetAreas")]
        public async Task<IActionResult> GetAreas()
        {
            var areas = await _context1.areas.ToListAsync();
            return Ok(areas);
        }


        [HttpGet("GetPassengersByName")]
        public async Task<IActionResult> GetPassengersByName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                return BadRequest("Name is required");

            var passengers = await _context1.Passenger
                .Where(p => p.PassengerFullName.StartsWith(name))
                .ToListAsync();

           
            await _hubContext.Clients.All.SendAsync("PassengersFound", passengers);

            return Ok(passengers);
        }



        [HttpGet("HelloWorld")]
        public async Task<IActionResult> HelloWorld()
        {
            var response = new
            {
                msg = "HelloWorld",
                status = 200
            };

            return Ok(response);
        }

    }
}
