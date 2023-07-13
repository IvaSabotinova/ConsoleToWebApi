using ConsoleToWebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConsoleToWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[BindProperties(SupportsGet = true)]
    public class CountriesController : ControllerBase
    {
        // [BindProperty(SupportsGet = true)]
         //public CountryModel Country { get; set; }

        //public string Name { get; set; }

        //public int Population { get; set; }

        //public int Area { get; set; }

        [HttpPost("{id}")]
        public IActionResult AddCountry([FromRoute] int id,[FromHeader] string developer,
             string course, string accept)
        {
            return Ok($"Name={developer}");


        }

        [HttpGet("search")]
        public IActionResult SearchCountries([ModelBinder(typeof(CustomBinder))] string[] countries)
        {
            return Ok(countries);
        }

        [HttpGet("{id}")]
        public IActionResult CountryDetails([ModelBinder(Name = "Id")] CountryModel country)
        {
            return Ok(country);
        }
    }
}
