using System;
using AcquirerApi.Request;
using AcquirerApi.Response;

namespace AcquirerApi.Services
{
    public interface ITransactionService
    {
        TransactionResponse Add(TransactionRequest transactionRequest);
    }
}
