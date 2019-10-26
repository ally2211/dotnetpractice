using System;

namespace ToDoAPI
{
    public class WeatherForecast
    {
        public DateTime DateAndTime { get; set; }

        public int TemperatureInCelsius { get; set; }

        public int TemperatureInFarenheit => 32 + (int)(TemperatureInCelsius / 0.5556);

        public string Summary { get; set; }
    }
}
