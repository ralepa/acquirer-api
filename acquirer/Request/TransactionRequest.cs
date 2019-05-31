using System;
namespace acquirer.Request
{
    public class TransactionRequest
    {
        public decimal Valor { get; set; }
        public string Adquirente { get; set; }
        public string Bandeira { get; set; }
        public string Tipo


        public TransactionRequest()
        {
        }
    }
}
