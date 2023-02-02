using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BookstoreApp
{
    internal class BookstoreModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }        
        public string Username { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Password { get; set; }
    }
}
