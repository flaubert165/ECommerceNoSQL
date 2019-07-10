using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ECommerceNoSQL.Domain.Entities
{
    public abstract class Entity
    {

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public long Id { get; private set; }
    }
}
