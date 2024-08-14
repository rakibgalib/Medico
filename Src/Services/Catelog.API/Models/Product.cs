using MongoDB.Bson.Serialization.Attributes;

namespace Catelog.API.Models
{
    public class Product
    {
        [BsonId]
       public int Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        public string Summery { get; set; }
        public string ImageFile { get; set; }
    }
}
