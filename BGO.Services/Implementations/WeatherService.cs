using BGO.Models;
using BGO.Services.DTOs.WeatherDTO;
using BGO.Services.Helpers;
using BGO.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace BGO.Services.Implementations
{
    public class WeatherService : IWeatherService
    {

        public async Task<LocationWeatherResponse> GetLocationWeather(WeatherRequest request)
        {
            string APIkey = ApiKeyContainer.GetKey();
            HttpClient Client = new HttpClient();
            HttpResponseMessage response = await Client.GetAsync($"https://api.openweathermap.org/data/3.0/onecall?lat={request.lat}&lon={request.lon}&appid={APIkey}");
            if (response.StatusCode == HttpStatusCode.OK)
            {
                WeatherResponse? weatherResponse = null;
                weatherResponse = await response.Content.ReadFromJsonAsync<WeatherResponse>();
                if (weatherResponse != null)
                {
                    List<BGO.Services.DTOs.WeatherDTO.Weather> weatherList = new List<BGO.Services.DTOs.WeatherDTO.Weather>();
                    foreach (var item in weatherResponse.current.weather) {
                        weatherList.Add(new DTOs.WeatherDTO.Weather
                        {
                            id = item.id,
                            main = item.main,
                            description = item.description,
                            icon = item.icon
                        });
                    }


                    return new LocationWeatherResponse
                    {
                        lat = weatherResponse.lat,
                        lon = weatherResponse.lon,
                        timezone = weatherResponse.timezone,
                        current = new DTOs.WeatherDTO.CurrentWeather
                        {
                            dt = weatherResponse.current.dt,
                            temp = weatherResponse.current.temp,
                            humidity = weatherResponse.current.humidity,
                            wind_speed = weatherResponse.current.wind_speed,
                            weather = weatherList
                        }

                    };
                }
                else
                {
                    return new LocationWeatherResponse
                    {
                        IsSuccesful = false,
                        Message = await response.Content.ReadAsStringAsync()
                    };
                }
            }
            else
            {
                Console.WriteLine(response.StatusCode.ToString());
                return new LocationWeatherResponse
                {
                    IsSuccesful = false,
                    Message = await response.Content.ReadAsStringAsync()

                };
            }

            
        }
    }
}
