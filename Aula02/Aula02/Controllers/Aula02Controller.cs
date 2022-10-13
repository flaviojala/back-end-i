using Microsoft.AspNetCore.Mvc;

namespace Aula02.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Aula02Controller : ControllerBase
    {

        private static readonly string[] MoviesName = new[]
        {
        "StarShipTroopers", "StarWars", "Rambo", "DaddyDayCare"
    };
        [HttpGet("GetMovies")]
        public string[] Get()
        {
            return MoviesName;
        }
    }
}
