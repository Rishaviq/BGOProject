using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BGO.Services.DTOs.WeatherDTO
{
    public class CurrentWeather
    {
        
        public float dt {  get; set; }
        public float temp { get; set; }
        public int humidity {  get; set; }
        public float wind_speed {  get; set; }
        public List<Weather>? weather { get; set; }

    }
}
