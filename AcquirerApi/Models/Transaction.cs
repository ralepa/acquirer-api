using System;
using AcquirerApi.Enums;

namespace AcquirerApi.Models
{
    public class Transaction
    {
        public long MerchantId { get; set; }

        public long AcquirerId { get; set; }

        public long BrandId { get; set; }

        public TransactionType TransactionType { get; set; }

        public decimal Value { get; set; }
    }
}
