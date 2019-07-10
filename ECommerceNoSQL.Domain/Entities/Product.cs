using MongoDB.Bson.Serialization.Attributes;

namespace ECommerceNoSQL.Domain.Entities
{
    public class Product : Entity
    {
        [BsonElement("Title")]
        public string Title { get; private set; }

        [BsonElement("Description")]
        public string Description { get; private set; }

        [BsonElement("Image")]
        public string Image { get; private set; }

        [BsonElement("Price")]
        public decimal Price { get; private set; }

        [BsonElement("QuantityOnHand")]
        public decimal QuantityOnHand { get; private set; }

        public Product() { }

        public Product(string title, string description, string image, decimal price, decimal quantity)
        {
            Title = title;
            Description = description;
            Image = image;
            Price = price;
            QuantityOnHand = quantity;
        }

        public override string ToString()
        {
            return Title;
        }

        public void DecreaseQuantity(decimal quantity)
        {
            QuantityOnHand -= quantity;
        }
    }
}
