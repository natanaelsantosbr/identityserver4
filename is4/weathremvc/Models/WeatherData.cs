﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace weathremvc.Models
{
    public class WeatherData
    {
        public DateTime Date { get; set; }
        public int TemperatureC { get; set; }
        public int TemperatureF => 32 + (int)(this.TemperatureC / 0.5556);
        public string Summary { get; set; }
    }
}
