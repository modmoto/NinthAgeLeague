using MongoDB.Bson;

namespace NinthAgeCmsToArmyBook.Shared.MongoDb;

public interface IIdentifiable
{
    public ObjectId Id { get; }
}