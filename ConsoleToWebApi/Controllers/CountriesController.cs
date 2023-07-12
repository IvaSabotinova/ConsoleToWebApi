using ConsoleToWebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConsoleToWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [BindProperties(SupportsGet = true)]
    public class CountriesController : ControllerBase
    {
        // [BindProperty(SupportsGet = true)]
         public CountryModel Country { get; set; }

        //public string Name { get; set; }

        //public int Population { get; set; }

        //public int Area { get; set; }

        [HttpGet("")]
        public IActionResult AddCountry()
        {
            return Ok($"Name={this.Country.Name}, " +
                $"Population={this.Country.Population}, " +
                $"Area={this.Country.Area}");
        }
    }
}
