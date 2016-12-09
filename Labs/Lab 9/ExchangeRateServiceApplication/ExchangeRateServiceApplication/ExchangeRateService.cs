using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Globalization;

namespace ExchangeRateServiceApplication
{
    public class ExchangeRateService : IExchangeRateService
    {

        public ExchangeRateResponse GetExchangeRate(ExchangeRateRequest request)
        {
            ExchangeRateResponse resp = new ExchangeRateResponse();

            Console.WriteLine(string.Format("Received ExchangeRequest for {0} to {1}.",request.FromCurrency, request.ToCurrency));

            resp.ExhangeRate = decimal.Parse(string.Format("{0}{1}{2}",
                (DateTime.Now.Minute % 9),
                NumberFormatInfo.CurrentInfo.CurrencyDecimalSeparator,
                DateTime.Now.Minute));

            return resp;
        }
    }
}
