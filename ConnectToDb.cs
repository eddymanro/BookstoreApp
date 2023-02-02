using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreApp
{
    internal class ConnectToDb
    {
        private const string connectionString = "mongodb://localhost:27017";
        private const string databaseName = "BookstoreDatabase";
        private string collectionName = "Bookstores";

        public ConnectToDb() { }
        // getters
        public string getConnectionString() { return connectionString; }
        public string getDatabaseName() { return databaseName; }
        public string getCollectionName() { return collectionName; }
        // setter
        public void setCollectionName(string name) { this.collectionName = name; }
    }
}
