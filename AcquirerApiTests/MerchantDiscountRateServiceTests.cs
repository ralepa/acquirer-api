using System;
using AcquirerApi.Cache;
using AcquirerApi.Enums;
using AcquirerApi.Models;
using AcquirerApi.Services;
using FluentAssertions;
using Xunit;

namespace AcquirerApiTests
{
    public class MerchantDiscountRateServiceTests
    {
        private MerchantDiscountRateService merchantDiscountRateService;

        public MerchantDiscountRateServiceTests()
        {
            merchantDiscountRateService = new MerchantDiscountRateService();
        }

        [Fact]
        public void Given_single_transaction_when_it_has_valid_data_calculate_mdr()
        {
            // Arrange
            var transaction1 = new Transaction
            {
                AcquirerId = 1, // Adquirente A
                BrandId = 1, // Visa
                TransactionType = TransactionType.CREDIT,
                Value = 100
            };

            var transaction2 = new Transaction
            {
                AcquirerId = 1, // Adquirente A
                BrandId = 2, // Master
                TransactionType = TransactionType.CREDIT,
                Value = 100
            };

            // Act 

            var mdr1 = merchantDiscountRateService.CalculateMerchantDiscountRate(transaction1);
            var mdr2 = merchantDiscountRateService.CalculateMerchantDiscountRate(transaction2);

            // Assert

            mdr1.Should().BeApproximately(97.75m, 2);
            mdr2.Should().BeApproximately(97.65m, 2);

        }
    }
}
