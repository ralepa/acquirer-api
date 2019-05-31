using System;
using System.Collections.Generic;

namespace AcquirerApi.Model
{
    public class Acquirer
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public IList<DiscountRate> DiscountRates { get; set; }
    }
}
