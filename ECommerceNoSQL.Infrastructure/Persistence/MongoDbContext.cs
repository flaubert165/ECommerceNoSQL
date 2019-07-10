using ECommerceNoSQL.Infrastructure.DataContext;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDbGenericRepository;
using System;


namespace ECommerceNoSQL.Infrastructure.Persistence
{
    class MongoDbContext : IMongoDbContext
    {
        private IMongoDatabase Database { get; set; }
        public IMongoClient Client { get; set; }
        IMongoDatabase IMongoDbContext.Database => throw new NotImplementedException();

        public MongoDbContext(IECommerceDbSettings settings)
        {
            Client = new MongoClient(settings.ConnectionString);
            Database = Client.GetDatabase(settings.DatabaseName);
        }

        public void DropCollection<TDocument>(string partitionKey = null)
        {
            throw new NotImplementedException();
        }

        public IMongoCollection<TDocument> GetCollection<TDocument>(string partitionKey = null)
        {
            return Database.GetCollection<TDocument>(partitionKey);
        }

        public void SetGuidRepresentation(GuidRepresentation guidRepresentation)
        {
            throw new NotImplementedException();
        }
    }
}
