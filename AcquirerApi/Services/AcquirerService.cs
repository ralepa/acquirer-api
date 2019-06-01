using System;
using System.Collections.Generic;
using System.Linq;
using AcquirerApi.Cache;
using AcquirerApi.Enums;
using AcquirerApi.Repositories;
using AcquirerApi.Responses;

namespace AcquirerApi.Services
{
    public class AcquirerService : IAcquirerService
    {
        private AcquirerRepository acquirerRepository;

        public AcquirerService()
        {
            acquirerRepository = new AcquirerRepository();
        }

        public IList<AcquirerResponse> GetAll()
        {

            var acquirers = acquirerRepository.GetAll();

            var acquirerResponses = acquirers.Select(a => new AcquirerResponse
            {
                Adquirente = a.Name,
                Taxas = new List<MerchantDiscountRateResponse>
                {
                    new MerchantDiscountRateResponse
                    {
                        Bandeira = a.DiscountRates.First(mdr => mdr.Brand.Id == 1).Brand.Name,
                        Credito = a.DiscountRates.Single(mdr => mdr.Brand.Id == 1 && mdr.TransactionType == TransactionType.CREDIT).Rate,
                        Debito = a.DiscountRates.Single(mdr => mdr.Brand.Id == 1 && mdr.TransactionType == TransactionType.DEBIT).Rate
                    },
                    new MerchantDiscountRateResponse
                    {
                        Bandeira = a.DiscountRates.First(mdr => mdr.Brand.Id == 2).Brand.Name,
                        Credito = a.DiscountRates.Single(mdr => mdr.Brand.Id == 2 && mdr.TransactionType == TransactionType.CREDIT).Rate,
                        Debito = a.DiscountRates.Single(mdr => mdr.Brand.Id == 2 && mdr.TransactionType == TransactionType.DEBIT).Rate
                    }
                }
            }).ToList();

            return acquirerResponses;
        }
    }
}
