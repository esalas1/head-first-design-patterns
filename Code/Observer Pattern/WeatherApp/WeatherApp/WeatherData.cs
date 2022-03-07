using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp
{
    public class WeatherData
    {
        // Instance variable declarations here:

        public void MeasurementsChanged()
        {
            double temp = GetTemperature();
            double humidity = GetHumidity();
            double pressure = GetPressure();

            currentConditionsDisplay.update();
            statisticsDisplayUpdate.update();
            forecastDisplay.update();


        }
    }
}
