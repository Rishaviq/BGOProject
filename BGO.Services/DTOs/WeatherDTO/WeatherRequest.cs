using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BGO.Services.DTOs.WeatherDTO
{
    public class WeatherRequest
    {
        [Range(-90, 90, ErrorMessage = "Out of range")]
        public float lat { get; set; }
        [Range(-180, 180, ErrorMessage = "Out of range")]
        public float lon { get; set; }
    }
}
