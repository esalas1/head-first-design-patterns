﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp
{
    public interface IWeatherObserver
    {
        public void Update(WeatherInfo weatherDTO);
    }
}
