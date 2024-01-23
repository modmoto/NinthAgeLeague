﻿using System.Threading.Tasks;
using MongoDB.Driver;
using NinthAgeCmsToArmyBook.Shared.MongoDb;

namespace NinthAgeCmsToArmyBook.Api.ReadModelBase
{
    public class VersionRepository : MongoDbRepositoryBase, IVersionRepository
    {
        public VersionRepository(MongoClient mongoClient) : base(mongoClient)
        {
        }

        public async Task<HandlerVersion> GetLastVersion<T>()
        {
            var loadFirst = await LoadFirst<HandlerVersion>(h => h.HandlerName == HandlerVersion.CreateFrom<T>(null).HandlerName);
            return loadFirst ?? HandlerVersion.CreateFrom<T>(null);
        }

        public Task SaveLastVersion<T>(HandlerVersion lastVersion)
        {
            return Upsert(lastVersion, v => v.HandlerName == lastVersion.HandlerName);
        }
    }
}