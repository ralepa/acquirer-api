using System;
using System.Linq;
using AcquirerApi.Enums;
using AcquirerApi.Models;
using AcquirerApi.Repositories;
using AcquirerApi.Request;
using AcquirerApi.Response;

namespace AcquirerApi.Services
{
    public class TransactionService : ITransactionService
    {
        private readonly TransactionRepository transactionRepository;
        private readonly AcquirerRepository acquirerRepository;
        private readonly MerchantDiscountRateService merchantDiscountRateService;

        public TransactionService()
        {
            transactionRepository = new TransactionRepository();
            merchantDiscountRateService = new MerchantDiscountRateService();
        }

        /// <summary>
        /// Adiciona transação e caulcula MDR
        /// </summary>
        /// <returns>The add.</returns>
        /// <param name="transactionRequest">Transaction request.</param>
        public TransactionResponse Add(TransactionRequest transactionRequest)
        {
            var acquirer = GetAcquirer(transactionRequest.Adquirente);

            var transaction = new Transaction
            {
                TransactionType = GetTransactionType(transactionRequest.Tipo),
                AcquirerId = acquirer.Id,
                BrandId = acquirer.DiscountRates.First(mdr => mdr.Brand.Name.ToLower() == transactionRequest.Bandeira).Brand.Id,
                Value = transactionRequest.Valor
            };

            transactionRepository.Add(transaction);
            var netMdr = merchantDiscountRateService.CalculateMerchantDiscountRate(transaction);

            var response = new TransactionResponse(netMdr);

            return response;
        }

        private Acquirer GetAcquirer(string adquirente)
        {
            if (adquirente == null)
            {
                throw new ArgumentNullException(nameof(adquirente), "Adquirente não informada");
            }
            var acquirer = acquirerRepository.GetByName(adquirente);
            return acquirer;
        }

        private TransactionType GetTransactionType(string tipo)
        {
            if (tipo == null)
            {
                throw new ArgumentNullException(nameof(tipo), "Tipo da transação não informado");
            }
            switch (tipo)
            {
                case "credito":
                    return TransactionType.CREDIT;
                case "debito":
                    return TransactionType.DEBIT;
                case "vale":
                    return TransactionType.VOUCHER;
                default:
                    throw new ArgumentException("Tipo de transação inválida");
            }
        }
    }
}
