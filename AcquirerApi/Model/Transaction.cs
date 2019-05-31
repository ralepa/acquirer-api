using System;
namespace AcquirerApi.Model
{
    public class Transaction
    {
        public Merchant Merchant { get; set; }

        public Acquirer Acquirer { get; set; }

        public Brand Brand { get; set; }

        public decimal Value { get; set; }

        public Transaction()
        {
        }
    }
}
