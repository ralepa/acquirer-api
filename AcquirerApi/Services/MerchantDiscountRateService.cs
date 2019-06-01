using System;
using System.Linq;
using AcquirerApi.Cache;
using AcquirerApi.Models;

namespace AcquirerApi.Services
{
    public class MerchantDiscountRateService : IMerchantDiscountRateService
    {
        private readonly ApplicationCache applicationCache;

        public MerchantDiscountRateService()
        {
            applicationCache = ApplicationCache.GetInstance();
        }

        /// <summary>
        /// Calcula MDR a partir de uma transação
        /// </summary>
        /// <returns>The merchant discount rate.</returns>
        /// <param name="transaction">Transaction.</param>
        public decimal CalculateMerchantDiscountRate(Transaction transaction)
        {
            var acquirer = applicationCache.Acquirers
                                           .SingleOrDefault(a => a.Id == transaction.AcquirerId);

            if (acquirer == null)
            {
                throw new InvalidOperationException("Transação com adquirente inválida");
            }

            var discountRate = acquirer.DiscountRates
                                       .SingleOrDefault(mdr => mdr.TransactionType == transaction.TransactionType &&
                                                        mdr.Brand.Id == transaction.BrandId);

            if (discountRate == null)
            {
                throw new InvalidOperationException($"Transação com operação inválida para a adquirente {acquirer.Name}");
            }

            var rate = discountRate.Rate;

            var netMdr = Math.Round((transaction.Value - transaction.Value * (rate / 100)) * 100) / 100;

            return netMdr;
        }
    }
}
