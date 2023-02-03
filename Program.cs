using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using System;

namespace BookstoreApp
{
    internal static class Program
    {               
        static List<BookstoreModel> bookstoresList = new List<BookstoreModel>();

        public static void populateArraylist(IMongoCollection<BookstoreModel> collection)
        {
            foreach (BookstoreModel obj in collection.AsQueryable().ToList())
            {
                bookstoresList.Add(obj);
                obj.printBookstore();
            }
        }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {                       
            ConnectToDb connDB = new ConnectToDb();
            MongoClient dbClient = new MongoClient(connDB.getConnectionString());
            var client = new MongoClient();          
            var db = client.GetDatabase(connDB.getDatabaseName()); // get the database
            var collection  = db.GetCollection<BookstoreModel>(connDB.getCollectionName()); // get the collection / document

            populateArraylist(collection); // populates array list and prints objects to the console
                        
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new WelcomeWindow());
            
        }
    }
}