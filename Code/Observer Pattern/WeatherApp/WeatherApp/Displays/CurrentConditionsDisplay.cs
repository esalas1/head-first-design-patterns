using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp
{
    public class CurrentConditionsDisplay : IWeatherDisplay, IWeatherObserver
    {
        private double Temperature;
        private double Humidity;
        private double Pressure;
        private WeatherData _weatherData;

        public CurrentConditionsDisplay(WeatherData weatherData)
        {
            _weatherData = weatherData;
            _weatherData.RegisterObserver(this);
        }

        public void Update(WeatherInfo weatherInfo)
        {
            Temperature = weatherInfo.Temperature;
            Humidity = weatherInfo.Humidity;
            Pressure = weatherInfo.Pressure;
            this.Display();
        }

        public void Display()
        {
            Console.WriteLine("Weather is as follows: ");
            Console.WriteLine("Temperature: " + Temperature);
            Console.WriteLine("Humidity: " + Humidity);
            Console.WriteLine("Pressure: " + Pressure);

        }
    }
}
