using Microsoft.Extensions.OptionsModel;
using MongoDB.Driver;
using Mongo.Connector.Entity;

namespace Mongo.Connector.Repository
{
    public class LogRepository : ILogRepository
    {
        private readonly IMongoDatabase _database;
        private readonly Settings _settings;

        public LogRepository(IOptions<Settings> settings)
        {
            _settings = settings.Value;
            _database = Connect();
        }

        public void Add(ApplicationLog applicationLog)
        {
            _database.GetCollection<ApplicationLog>("Logger").InsertOneAsync(applicationLog);
        }

        private IMongoDatabase Connect()
        {
            var client = new MongoClient(_settings.MongoConnection);
            var database = client.GetDatabase(_settings.Database);

            return database;
        }
    }
}
