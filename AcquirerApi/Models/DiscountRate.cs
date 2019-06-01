using System;
using AcquirerApi.Enums;

namespace AcquirerApi.Models
{
    public class DiscountRate
    {
        public Brand Brand { get; set; }
        public TransactionType TransactionType { get; set; }
        public decimal Rate { get; set; }
    }
}
