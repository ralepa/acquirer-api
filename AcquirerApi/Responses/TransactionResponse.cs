using System;
namespace AcquirerApi.Response
{
    public class TransactionResponse
    {
        public decimal ValorLiquido { get; }

        public TransactionResponse(decimal valorLiquido)
        {
            ValorLiquido = valorLiquido;
        }
    }
}
