using Mongo.Connector.Entity;

namespace Mongo.Connector.Repository
{
    public interface ILogRepository
    {
        void Add(ApplicationLog sample);
    }
}
