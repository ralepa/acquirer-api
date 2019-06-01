using System;
namespace AcquirerApi.Request
{
    public class TransactionRequest
    {
        public decimal Valor { get; set; }

        public string Adquirente { get; set; }

        public string Bandeira { get; set; }

        public string Tipo { get; set; }

    }
}
