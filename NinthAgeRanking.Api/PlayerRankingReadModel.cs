using System.Text.Json.Serialization;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using NinthAgeCmsToArmyBook.Shared.Ladder;
using NinthAgeCmsToArmyBook.Shared.MongoDb;

namespace NinthAgeCmsToArmyBook.Api
{
    public class PlayerRankingReadModel : IIdentifiable
    {
        [JsonIgnore]
        public ObjectId Id { get; set; }
        [BsonIgnore]
        [JsonPropertyName("id")]
        public string IdRaw { get; set; }
        public string Name { get; set; }
        public int Wins { get; set; }
        public double WinRate { get; set; }
        public int Losses { get; set; }
        public int Draws { get; set; }
        public int Mmr { get; set; }
        
        [BsonIgnore]
        public int MatchCount => Wins + Losses + Draws;
    }
}