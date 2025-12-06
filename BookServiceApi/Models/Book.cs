using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BookServiceApi.Models
{
    public class Book
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("Title")]
        public string Title { get; set; } = null!;

        [BsonElement("Author")]
        public string Author { get; set; } = null!;

        [BsonElement("ISBN")]
        public string ISBN { get; set; } = null!;
    }
}