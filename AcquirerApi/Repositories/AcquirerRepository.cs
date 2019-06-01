using System;
using System.Collections.Generic;
using System.Linq;
using AcquirerApi.Cache;
using AcquirerApi.Models;

namespace AcquirerApi.Repositories
{
    public class AcquirerRepository : IAcquirerRepository
    {
        private readonly ApplicationCache applicationCache;

        public AcquirerRepository()
        {
            applicationCache = ApplicationCache.GetInstance();
        }

        public Acquirer Add(Acquirer t)
        {
            var maxId = applicationCache.Acquirers.Max(a => a.Id);
            t.Id = maxId + 1;
            applicationCache.Acquirers.Add(t);
            return t;
        }

        public Acquirer Get(long id)
        {
            return applicationCache.Acquirers.SingleOrDefault(a => a.Id == id);
        }

        public ICollection<Acquirer> GetAll()
        {
            return applicationCache.Acquirers;
        }

        public void Remove(Acquirer t)
        {
            applicationCache.Acquirers.Remove(t);
        }

        public Acquirer GetByName(string adquirente)
        {
            return applicationCache.Acquirers.SingleOrDefault(a => a.Name.Split(' ')[1] == adquirente);
        }
    }
}
