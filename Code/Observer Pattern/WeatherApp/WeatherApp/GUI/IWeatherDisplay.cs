﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp
{
    interface IWeatherDisplay
    {
        public void Display(WeatherInfo weatherInfo);
    }
}
