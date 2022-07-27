using MongoDB.Bson.Serialization.Attributes;

namespace Pag_Web.models
{
    public class Productos
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string id { get; set; }
        [BsonElement("Nombre")]
        public string Nombre { get; set; }
        [BsonElement("Precio")]
        public decimal Precio { get; set; }
    }
}
