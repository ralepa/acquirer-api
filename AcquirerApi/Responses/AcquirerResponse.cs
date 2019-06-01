using System;
using System.Collections.Generic;

namespace AcquirerApi.Responses
{
    public class AcquirerResponse
    {

        public string Adquirente { get; set; }
        public IList<MerchantDiscountRateResponse> Taxas { get; set; }

    }
}
