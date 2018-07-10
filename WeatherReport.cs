using System;
namespace WeatherMicroservice
{       
    public class WeatherReport
    {
        private static readonly string[] PossibleConditions =
        {
            "Sunny",
            "Mostly Sunny",
            "Partly Sunny",
            "Partly Cloudy",
            "Mostly Cloudy",
            "Rain"
        };

        public int HighTemperatureFahrenheit { get;}
        public int LowTemperatureFahrenheit { get;}
        public int AverageWithSpeedMph { get;}
        public string Condition { get;}

        public WeatherReport (double latitude, double longitude, int daysInFuture)
        {
            var generator = new Random((int)(latitude + longitude) + daysInFuture);
            HighTemperatureFahrenheit = generator.Next(40, 100);
            LowTemperatureFahrenheit = generator.Next(0, HighTemperatureFahrenheit);
            AverageWithSpeedMph = generator.Next(0,45);
            Condition = PossibleConditions[generator.Next(0, PossibleConditions.Length-1)];        
        }
    }
}