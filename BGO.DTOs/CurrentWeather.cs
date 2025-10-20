using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BGO.Models
{
    public class CurrentWeather
    {
        
        public float dt {  get; set; }
        public float temp { get; set; }
        public int humidity {  get; set; }
        public float wind_speed {  get; set; }
        public  List<Weather>? weather { get; set; }
        
    }
}
