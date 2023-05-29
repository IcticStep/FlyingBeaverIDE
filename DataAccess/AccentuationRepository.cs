using Domain;
using MongoDB.Bson;
using MongoDB.Driver;

namespace DataAccess;

public class AccentuationRepository : IAccentuationsRepository
{
    public AccentuationRepository()
    {
        _database = _client.GetDatabase(DataBaseName);
        _data = _database.GetCollection<AccentuationDto>(TargetCollectionName);
    }

    private const string UserName = "";
    private const string UserPassword = "";
    private const string ConnectionPath = "";
    private const string DataBaseName = "FlyingBeaverDb";
    private const string TargetCollectionName = "Accentuations";
    private static readonly MongoClient _client = new(ConnectionPath);

    private readonly IMongoDatabase _database;
    public IMongoCollection<AccentuationDto> _data;

    public int Count() => (int)_data.EstimatedDocumentCount();

    public bool IsEmpty() => Count() > 0;

    public Accentuation? GetAccentuation(string word)
    {
        var filter = new BsonDocument { { "Word", word.ToLowerInvariant() } };
        var result = _data
            .Find(filter)
            .FirstOrDefault();
        if (result is null)
            return null;
        
        return new(result.Word, result.Accentuations);
    }
}