using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp
{
    public class WeatherData
    {
        private List<WeatherObserver> Observers;
        private WeatherInfo WeatherInfo= new WeatherInfo();

        public WeatherData()
        {
            Observers = new List<WeatherObserver>();
        }

        public void RegisterObserver(WeatherObserver observer)
        {
            Observers.Add(observer);
        }
        
        public void RemoveObserver(WeatherObserver observer)
        {
            Observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (WeatherObserver observer in Observers)
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
