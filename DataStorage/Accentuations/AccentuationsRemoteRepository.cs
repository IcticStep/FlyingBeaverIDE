﻿using DataStorage.Accentuations.Api;
using Domain.Main;
using MongoDB.Bson;
using MongoDB.Driver;

namespace DataStorage.Accentuations;

public class AccentuationsRemoteRepository : IReadOnlyAccentuationsRepository
{
    public AccentuationsRemoteRepository(DataBaseCredentials credentials)
    {
        _client = new(credentials.ConnectionString);
        _database = _client.GetDatabase(DataBaseName);
        _data = _database.GetCollection<AccentuationDto>(TargetCollectionName);
    }

    private const string DataBaseName = "FlyingBeaverDb";
    private const string TargetCollectionName = "Accentuations";
    private readonly MongoClient _client;

    private readonly IMongoDatabase _database;
    private IMongoCollection<AccentuationDto> _data;

    public int Count() => (int)_data.EstimatedDocumentCount();

    public bool IsEmpty() => Count() > 0;

    public Accentuation? GetAccentuationSyllable(string word)
    {
        var filter = new BsonDocument { { "Word", word.ToLowerInvariant() } };
        var result = _data
            .Find(filter)
            .FirstOrDefault();
        if (result is null)
            return null;

        for (var i = 0; i < result.Accentuations.Count; i++)
            result.Accentuations[i] -= 1;
        return new(result.Word, result.Accentuations);
    }

    public IEnumerable<Accentuation> GetAll() =>
        _data
            .Find("{ }")
            .ToEnumerable()
            .Select(x => new Accentuation(x.Word, x.Accentuations));
}