using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BGO.Services.DTOs.WeatherDTO
{
    public class LocationWeatherResponse : ResponseDTO
    {
        [Range(-90,90, ErrorMessage = "Out of range")]
        public float lat { get; set; }
        [Range(-180,180,ErrorMessage ="Out of range")]
        public float lon { get; set; }
        public string? timezone { get; set; }
        public CurrentWeather? current { get; set; }
    }
}
