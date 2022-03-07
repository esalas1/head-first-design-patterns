using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp
{
    abstract class WeatherDisplay : IWeatherDisplay
    {
        public abstract void Display(WeatherInfo weatherInfo);
    }
}
