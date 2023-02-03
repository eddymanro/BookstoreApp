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
        [BsonElement("Username")]
        public string Username { get; set; }
        [BsonElement("Name")]
        public string Name { get; set; }
        [BsonElement("City")]
        public string City { get; set; }
        [BsonElement("Password")]
        public string Password { get; set; }

        // helper Methods
        public void printBookstore() 
        {
            Console.WriteLine("-----------------");
            Console.WriteLine("Object from class: " + this.ToString());
            Console.WriteLine("Id: " + this.Id);
            Console.WriteLine("Username: " + this.Username);
            Console.WriteLine("Name: " + this.Name);
            Console.WriteLine("City: " + this.City);
            Console.WriteLine("Password: " + this.Password);            
        }

    }
}
