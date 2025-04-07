using Shared;
using MongoDB.Driver;

namespace ServerAPI2.Repositories;

public class TojRepositoryMongoDB : ITojRepository
{
    private IMongoClient client;
    private IMongoCollection<Toj> TojCollection;

    public TojRepositoryMongoDB()
    {
        var mongoUri = "mongodb://localhost:27017/";

        try
        {
            client = new MongoClient(mongoUri);
        }
        catch (Exception e)
        {
            Console.WriteLine("Connection error: " + e.Message);
            throw;
        }

        var dbName = "Mydatabase";
        var collectionName = "toj";

        TojCollection = client.GetDatabase(dbName)
            .GetCollection<Toj>(collectionName);
    }

    public void Add(Toj item)
    {
        int max = 0;
        if (TojCollection.CountDocuments(Builders<Toj>.Filter.Empty) > 0)
        {
            max = MaxId();
        }

        item.Id = max + 1;
        TojCollection.InsertOne(item);
    }

    public void UpdateById(int id)
    {
        var deleteResult = TojCollection
            .DeleteOne(Builders<Toj>.Filter.Where(r => r.Id == id));
       
        
    }
    
    public List<Toj> GetAll()
    {
        var noFilter = Builders<Toj>.Filter.Empty;
        return TojCollection.Find(noFilter).ToList();
    }

    public void UpdateById(int id, Toj tojItem)
    {
        var updateDef = Builders<Toj>.Update
            .Set(x => x.Type, tojItem.Type)
            .Set(x => x.status, tojItem.status)
            .Set(x => x.size, tojItem.size)
            .Set(x => x.farve, tojItem.farve)
            .Set(x => x.imageUrl, tojItem.imageUrl)
            .Set(x => x.pris, tojItem.pris);

        TojCollection.UpdateOne(x => x.Id == id, updateDef);
    }

    public void DeleteById(int id)
    {
        TojCollection.DeleteOne(x => x.Id == id);
    }

    private int MaxId()
    {
        return GetAll().Select(t => t.Id).DefaultIfEmpty(0).Max();
    }
}