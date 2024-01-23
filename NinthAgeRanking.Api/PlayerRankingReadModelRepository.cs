﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using NinthAgeCmsToArmyBook.Shared.Ladder;
using NinthAgeCmsToArmyBook.Shared.MongoDb;

namespace NinthAgeCmsToArmyBook.Api
{
    public interface IRankingReadmodelRepository
    {
        Task<List<PlayerRankingReadModel>> LoadAllRanked();
        Task Upsert(List<PlayerRankingReadModel> rankingModels);
    }

    public class RankingReadmodelRepository : MongoDbRepositoryBase, IRankingReadmodelRepository
    {
        public RankingReadmodelRepository(MongoClient mongoClient) : base(mongoClient)
        {
        }
        
        public async Task<List<PlayerRankingReadModel>> LoadAllRanked()
        {
            var loadAllRanked = await LoadAll<PlayerRankingReadModel>();
            return loadAllRanked.OrderByDescending(i => i.Mmr).ToList();
        }

        public Task Upsert(List<PlayerRankingReadModel> rankingModels)
        {
            return UpsertMany(rankingModels);
        }
    }
}