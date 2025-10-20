using BGO.Services.DTOs.WeatherDTO;
using BGO.Services.Helpers;
using BGO.Services.Implementations;
using System.Threading.Tasks;

namespace test
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            ApiKeyContainer.SetKey("c8b6047ed05c353415fbe91e146db888");
            WeatherService weatherService = new WeatherService();
          LocationWeatherResponse response= await weatherService.GetLocationWeather(10, 20);
            Console.WriteLine(response);
        }
    }
}
