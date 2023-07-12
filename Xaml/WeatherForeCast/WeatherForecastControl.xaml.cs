using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Navigation;

namespace XamlTest.Xaml.WeatherForeCast
{
    public partial class WeatherForecastControl : UserControl
    {
        public WeatherForecastControl()
        {
            this.InitializeComponent();
            DataContext = new WeatherForecastViewModel(); ;
        }
    }
    public class WeatherForecastViewModel
    {
        public WeatherForecast[] Forecasts { get; set; }

        public WeatherForecastViewModel()
        {
            Forecasts = new[]
            {
                new WeatherForecast
                {
                    Date = new DateTime(2023, 7, 13),
                    TemperatureC = 25,
                    Summary = "Sunny"
                },
                new WeatherForecast
                {
                    Date = new DateTime(2023, 7, 14),
                    TemperatureC = 28,
                    Summary = "Partly Cloudy"
                },
                // Add more forecast items as needed
            };
        }
    }

    public partial class WeatherForecast
    {
        public DateTime Date { get; set; }
        public int TemperatureC { get; set; }
        public string Summary { get; set; }
        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
    }
}
