using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using System;

namespace BookstoreApp
{
    internal static class Program
    {          
        // local list of objects to work for different algos
        static List<BookstoreModel> bookStoresList = new List<BookstoreModel>();
        //static List<BooksModel> booksList = new List<BooksModel>();

        // helper function to populate the array lists
        /*
        public static void populateArraylist(IMongoCollection<BookstoreModel> collection)
        {
            foreach (BookstoreModel obj in collection.AsQueryable().ToList())
            {
                bookStoresList.Add(obj);
                obj.printBookstore();
            }
        }
        */

        public static void populateArraylist<T>(IMongoCollection<T> collection, List<T> list)
        {
            foreach (T obj in collection.AsQueryable().ToList())
            {
                list.Add(obj);                
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
            IMongoCollection<BookstoreModel> bookstoresCollecton  = db.GetCollection<BookstoreModel>(connDB.getCollectionName()); // get the collection / document
            //IMongoCollection<BooksModel> booksCollection = db.GetCollection<BooksModel>(connDB.getCollectionName()); // get the collection / document

            populateArraylist(bookstoresCollecton, bookStoresList); // populates array list and prints objects to the console
            //populateArraylist(booksCollection); //                     

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new WelcomeWindow());
            
        }
    }
}