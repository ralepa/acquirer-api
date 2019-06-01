using System;
using AcquirerApi.Models;

namespace AcquirerApi.Services
{
    public interface IMerchantDiscountRateService
    {
        decimal CalculateMerchantDiscountRate(Transaction transaction);


    }
}
