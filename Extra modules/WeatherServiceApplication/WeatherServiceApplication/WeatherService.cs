using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WeatherServiceApplication
{
    public class WeatherService : IWeatherService
    {

        public WeatherResponse GetForecast(WeatherRequest request)
        {
            WeatherResponse resp = new WeatherResponse();

            Console.WriteLine("Received request for " + string.Format("{0}, {1}", request.City, request.Country));

            if (request.Country != "Sweden" && request.Country != "Sverige")
            {
                resp.Forecast = "High humidity and risk of showers.";
            }
            else
            {
                if (request.City == "Stockholm")
                    resp.Forecast = "It's always sunny in A372";
                else
                    resp.Forecast = "DRY or WET. You choose.";
            }

            return resp;
        }
    }
}
