namespace NinthAgeCmsToArmyBook.Shared.MongoDb;

public interface IVersionable
{
    public long Version { get; set; }
}