using System;
using AcquirerApi.Enum;

namespace AcquirerApi.Model
{
    public class DiscountRate
    {
        public Brand Brand { get; set; }
        public TransactionType TransactionType { get; set; }
        public decimal Rate { get; set; }
    }
}
