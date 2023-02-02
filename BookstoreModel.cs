using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;


namespace BookstoreApp
{
    internal class BookstoreModel
    {
        public ObjectId Id { get; set; }
        public string Username { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Password { get; set; }
    }
}
