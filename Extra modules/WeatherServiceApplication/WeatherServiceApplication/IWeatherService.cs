using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WeatherServiceApplication
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IWeatherService" in both code and config file together.
    [ServiceContract]
    public interface IWeatherService
    {
        [OperationContract]
        WeatherResponse GetForecast(WeatherRequest request);
    }

    [DataContract]
    public class WeatherRequest
    {
        [DataMember]
        public string Country { get; set; }

        [DataMember]
        public string City { get; set; }
    }

    [DataContract]
    public class WeatherResponse
    {
        [DataMember]
        public string Forecast { get; set; }
    }
}
