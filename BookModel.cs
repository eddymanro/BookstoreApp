using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreApp
{
    internal class BookModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        [BsonElement("Title")]
        public string Title { get; set; }
        [BsonElement("Author")]
        public string Author { get; set; }
        [BsonElement("Publisher")]
        public string Publisher { get; set; }
        [BsonElement("Pages")]
        public int Pages { get; set; }

        // helper Methods
        public void printBook()
        {
            Console.WriteLine("-----------------");
            Console.WriteLine("Object from class: " + this.ToString());
            Console.WriteLine("Id: " + this.Id);
            Console.WriteLine("Title: " + this.Title);
            Console.WriteLine("Author: " + this.Author);
            Console.WriteLine("Publisher: " + this.Publisher);
            Console.WriteLine("Pages: " + this.Pages.ToString());
        }
    }
}
