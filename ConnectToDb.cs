using MongoDB.Driver;
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
        private const string bookStoresCollectionName = "Bookstores";
        private const string booksCollectionName = "Books";
        private MongoClient dbClient;
        private IMongoDatabase db;
        private IMongoCollection<BookstoreModel> bookstoresCollection;
        private IMongoCollection<BookModel> booksCollection;

        public ConnectToDb()
        {
            this.dbClient = new MongoClient(connectionString);
            this.db = this.dbClient.GetDatabase(databaseName);
            this.bookstoresCollection = this.db.GetCollection<BookstoreModel>(bookStoresCollectionName);
            this.booksCollection = this.db.GetCollection<BookModel>(booksCollectionName);
        }
        // getters        
        public MongoClient getDbClient() { return this.dbClient; }
        public IMongoDatabase getDb() { return this.db; }
        public IMongoCollection<BookstoreModel> getBookstoreCollection() { return this.bookstoresCollection; }
        public IMongoCollection<BookModel> getBooksCollection() { return this.booksCollection; }                     
    }
}
