using Mchine_Test.ServicesInterface;
using Microsoft.AspNetCore.Mvc;

namespace Mchine_Test.Controllers
{
    [ApiController]

    public class CountryController : ControllerBase
    {
        private readonly ICountryService _countryService;
       

        public CountryController(ICountryService countryService)
        {
            _countryService = countryService;
        }

        [HttpGet]
        [Route("getlist")]
        public async Task<IActionResult> GetCountry()
        {
            var result = await _countryService.GetCountry();
            return Ok(result);
        }
    }
    }