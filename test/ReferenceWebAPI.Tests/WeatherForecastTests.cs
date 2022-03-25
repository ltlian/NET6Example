using Xunit;

namespace ReferenceWebAPI.Tests
{
    public class WeatherForecastTests
    {
        [Fact]
        public void WeatherForecastConvertsCelsiusToFahrenHeit()
        {
            var weatherForecast = new WeatherForecast
            {
                TemperatureC = 20
            };

            var temperatureF = weatherForecast.TemperatureF;

            Assert.Equal(67, temperatureF);
        }
    }
}
