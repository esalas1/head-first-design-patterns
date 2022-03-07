using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp
{
    public class WeatherData
    {
        private List<IWeatherObserver> Observers;
        private WeatherInfo WeatherInfo= new WeatherInfo();

        public WeatherData()
        {
            Observers = new List<IWeatherObserver>();
        }

        public void RegisterObserver(IWeatherObserver observer)
        {
            Observers.Add(observer);
        }
        
        public void RemoveObserver(IWeatherObserver observer)
        {
            Observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (IWeatherObserver observer in Observers)
            {
                observer.Update(WeatherInfo);
            }
        }

        public void MeasurementsChanged(double temperature, double humidity, double pressure)
        {
            WeatherInfo.Temperature = temperature;
            WeatherInfo.Humidity = humidity;
            WeatherInfo.Pressure = pressure;
        }
    }
}
