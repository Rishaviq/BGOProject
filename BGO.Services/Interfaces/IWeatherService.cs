using BGO.Services.DTOs.WeatherDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BGO.Services.Interfaces
{
    public interface IWeatherService
    {
        public Task<LocationWeatherResponse> GetLocationWeather(WeatherRequest request);
    }
}
