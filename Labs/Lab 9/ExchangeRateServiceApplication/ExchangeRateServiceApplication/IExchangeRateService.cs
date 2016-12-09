using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ExchangeRateServiceApplication
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IExchangeRateService" in both code and config file together.
    [ServiceContract]
    public interface IExchangeRateService
    {
        [OperationContract]
        ExchangeRateResponse GetExchangeRate(ExchangeRateRequest request);
    }
    
    [DataContract]
    public class ExchangeRateRequest
    {
        [DataMember]
        public string FromCurrency { get; set; }
        [DataMember]
        public string ToCurrency { get; set; }
    }

    [DataContract]
    public class ExchangeRateResponse
    {
        [DataMember]
        public decimal ExhangeRate { get; set; }
    }
}
