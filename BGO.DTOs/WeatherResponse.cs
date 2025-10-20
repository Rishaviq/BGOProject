using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BGO.Models

{
    public class WeatherResponse
    {
        public float lat {  get; set; }
        public float lon {  get; set; }
        public string? timezone {  get; set; }
        public CurrentWeather? current { get; set; }
    }
}
