using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StationTest.Data;
using StationTest.Models;
namespace StationTest.Controllers
{



    [Route("api/stations")]
    [ApiController]
    public class GoBusController : Controller
    {

        private readonly ApplicationDbContext _context;

        public GoBusController(ApplicationDbContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<Station>>> GetStations()
        {
            var stations = await _context.Station
                .FromSqlRaw("EXEC dbo.pro_OnLine_New_Get_Stations @CompanyID = {0}", 1)
                .ToListAsync();

            foreach (var stat in stations) {

                stat.Auth = "Mina";

            }

            return Ok(stations);
        }
    }
}
