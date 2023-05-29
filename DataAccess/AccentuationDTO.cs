﻿using MongoDB.Bson;

namespace DataAccess;

public class AccentuationDto
{
    public string Word { get; set; }
    public List<int> Accentuations { get; set; }
    // ReSharper disable once InconsistentNaming
    public ObjectId _id { get; set; }
}