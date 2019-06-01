using System;
using System.Collections.Generic;
using System.Linq;
using AcquirerApi.Cache;
using AcquirerApi.Models;

namespace AcquirerApi.Repositories
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly ApplicationCache applicationCache;

        public TransactionRepository()
        {
            applicationCache = ApplicationCache.GetInstance();
        }

        public Transaction Add(Transaction t)
        {
            applicationCache.Transactions.Add(t);
            return t;
        }

        public ICollection<Transaction> GetAll()
        {
            return applicationCache.Transactions;
        }

        public void Remove(Transaction t)
        {
            applicationCache.Transactions.Remove(t);
        }
    }
}
