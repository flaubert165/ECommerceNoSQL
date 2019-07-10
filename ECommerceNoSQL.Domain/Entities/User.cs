using MongoDB.Bson.Serialization.Attributes;

namespace ECommerceNoSQL.Domain.Entities
{
    public class User : Entity
    {
        [BsonElement("Login")]
        public string Login { get; set; }

        [BsonElement("Password")]
        public string Password { get; set; }

        public User() { }

        public User(string login, string password)
        {
            Login = login;
            Password = password;
        }
    }
}
