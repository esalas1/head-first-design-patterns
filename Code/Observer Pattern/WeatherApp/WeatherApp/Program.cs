using System;

namespace WeatherApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WeatherData _weatherData = new WeatherData();

            CurrentConditionsDisplay currentConditionsDisplay = new CurrentConditionsDisplay(_weatherData);

            _weatherData.MeasurementsChanged(70, 80, 90);
            _weatherData.NotifyObservers();

            Console.ReadLine();
        }
    }
}