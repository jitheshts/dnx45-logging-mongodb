using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mongo.Connector.Entity
{
    public class ApplicationLog
    {
        public const int MaximumExceptionLength = 2000;
        public const int MaximumMessageLength = 4000;

        public ObjectId Id { get; set; }

        [BsonElement("date")]
        public DateTime Date { get; set; }
        [BsonElement("thread")]
        public string Thread { get; set; }
        [BsonElement("level")]
        public string Level { get; set; }
        [BsonElement("logger")]
        public string Logger { get; set; }
        [BsonElement("message")]
        public string Message { get; set; }
        [BsonElement("exception")]
        public String Exception { get; set; }
        [BsonElement("hostAddress")]
        public string HostAddress { get; set; }
        [BsonElement("username")]
        public string Username { get; set; }
        [BsonElement("browser")]
        public string Browser { get; set; }
        [BsonElement("url")]
        public string Url { get; set; }
    }
}
