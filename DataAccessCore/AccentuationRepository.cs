using MongoDB.Driver;

namespace DataBaseConnector;

public class AccentuationRepository
{
    private const string ConnectionPath = "mongodb://localhost:27017";
    private const string DataBaseName = "FlyingBeaverDb";
    private const string TargetCollectionName = "Accentuations";
    private static readonly MongoClient _client = new MongoClient(ConnectionPath);
    private readonly IMongoDatabase _database;
    private IMongoCollection<Accentuation> _data;

    public AccentuationRepository()
    {
        _database = _client.GetDatabase(DataBaseName);
        _data = _database.GetCollection<Accentuation>(TargetCollectionName);
    }

    public void Add()
    {
        
    }
}