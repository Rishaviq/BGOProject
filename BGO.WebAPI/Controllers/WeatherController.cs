using BGO.Services.DTOs.WeatherDTO;
using BGO.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace BGO.WebAPI.Controllers
{
    public class WeatherController : Controller
    {
        public readonly IWeatherService _weatherService;
        public WeatherController(IWeatherService weatherService) {
            _weatherService = weatherService;
        }

        [HttpGet]
        [Route("[controller]")]
        // GET: WeatherController
        public async Task<ActionResult<LocationWeatherResponse>> GetWeather(WeatherRequest? request)
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            
                LocationWeatherResponse response = await _weatherService.GetLocationWeather(request);
            if (response.IsSuccesful)
            {


                return response;
            }
            else { return StatusCode(StatusCodes.Status502BadGateway, response.Message); }
            
        }

        [HttpGet]
        [Route("Health")]
        // GET: WeatherController
        public ActionResult GetHealth()
        {
            return Ok();
        }


    }
}
