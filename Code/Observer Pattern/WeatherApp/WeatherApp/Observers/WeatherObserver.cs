using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp
{
    public abstract class WeatherObserver : IWeatherObserver
    {
        public abstract void Update(WeatherInfo weatherInfo);
    }
}
