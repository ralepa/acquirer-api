using System;
using System.Collections.Generic;
using AcquirerApi.Enums;
using AcquirerApi.Models;

namespace AcquirerApi.Cache
{
    public class ApplicationCache
    {
        public IList<Acquirer> Acquirers { get; private set; }

        public IList<Brand> Brands { get; private set; } = new List<Brand>();

        public IList<DiscountRate> DiscountRates { get; private set; } = new List<DiscountRate>();

        public IList<Merchant> Merchants { get; private set; } = new List<Merchant>();

        public IList<Transaction> Transactions { get; private set; } = new List<Transaction>();

        private static ApplicationCache instance;

        private ApplicationCache()
        {
            Acquirers = GenerateAcquirerData();
        }

        public static ApplicationCache GetInstance()
        {
            if (instance == null)
            {
                instance = new ApplicationCache();
            }

            return instance;
        }

        private List<Acquirer> GenerateAcquirerData()
        {
            var acquirers = new List<Acquirer>
            {
                new Acquirer
                {
                    Id = 1,
                    Name = "Adquirente A",
                    DiscountRates = new List<DiscountRate>
                    {
                        new DiscountRate
                        {
                            Brand = new Brand
                            {
                                Id = 1,
                                Name = "Visa"
                            },
                            Rate = 2.25m,
                            TransactionType = TransactionType.CREDIT
                        },
                        new DiscountRate
                        {
                            Brand = new Brand
                            {
                                Id = 1,
                                Name = "Visa"
                            },
                            Rate = 2.00m,
                            TransactionType = TransactionType.DEBIT
                        },
                        new DiscountRate
                        {
                            Brand = new Brand
                            {
                                Id = 2,
                                Name = "Master"
                            },
                            Rate = 2.35m,
                            TransactionType = TransactionType.CREDIT
                        },
                        new DiscountRate
                        {
                            Brand = new Brand
                            {
                                Id = 2,
                                Name = "Master"
                            },
                            Rate = 1.98m,
                            TransactionType = TransactionType.DEBIT
                        },
                    }

                },
                new Acquirer
                {
                    Id = 2,
                    Name = "Adquirente B",
                    DiscountRates = new List<DiscountRate>
                    {
                        new DiscountRate
                        {
                            Brand = new Brand
                            {
                                Id = 1,
                                Name = "Visa"
                            },
                            Rate = 2.50m,
                            TransactionType = TransactionType.CREDIT
                        },
                        new DiscountRate
                        {
                            Brand = new Brand
                            {
                                Id = 1,
                                Name = "Visa"
                            },
                            Rate = 2.08m,
                            TransactionType = TransactionType.DEBIT
                        },
                        new DiscountRate
                        {
                            Brand = new Brand
                            {
                                Id = 2,
                                Name = "Master"
                            },
                            Rate = 2.65m,
                            TransactionType = TransactionType.CREDIT
                        },
                        new DiscountRate
                        {
                            Brand = new Brand
                            {
                                Id = 2,
                                Name = "Master"
                            },
                            Rate = 1.75m,
                            TransactionType = TransactionType.DEBIT
                        },
                    }

                },
                new Acquirer
                {
                    Id = 3,
                    Name = "Adquirente C",
                    DiscountRates = new List<DiscountRate>
                    {
                        new DiscountRate
                        {
                            Brand = new Brand
                            {
                                Id = 1,
                                Name = "Visa"
                            },
                            Rate = 2.75m,
                            TransactionType = TransactionType.CREDIT
                        },
                        new DiscountRate
                        {
                            Brand = new Brand
                            {
                                Id = 1,
                                Name = "Visa"
                            },
                            Rate = 2.16m,
                            TransactionType = TransactionType.DEBIT
                        },
                        new DiscountRate
                        {
                            Brand = new Brand
                            {
                                Id = 2,
                                Name = "Master"
                            },
                            Rate = 3.10m,
                            TransactionType = TransactionType.CREDIT
                        },
                        new DiscountRate
                        {
                            Brand = new Brand
                            {
                                Id = 2,
                                Name = "Master"
                            },
                            Rate = 1.58m,
                            TransactionType = TransactionType.DEBIT
                        },
                    }

                }
            };

            return acquirers;
        }
    }
}
