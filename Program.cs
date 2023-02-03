using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using System;
using System.Runtime.CompilerServices;

namespace BookstoreApp
{
    internal static class Program
    {
        //static MongoClient dbClient = new MongoClient("mongodb://localhost:27017");
        //static IMongoDatabase db = dbClient.GetDatabase("BookstoreDatabase");
        //static IMongoCollection<BookstoreModel> bookstoresCollection = db.GetCollection<BookstoreModel>("Bookstores"); // get the collection / document
        //static IMongoCollection<BookModel> booksCollection = db.GetCollection<BookModel>("Books"); // get the collection /

        // local list of objects to work for different algos
        static List<BookstoreModel> bookStoresList = new List<BookstoreModel>();
        static List<BookModel> booksList = new List<BookModel>();


        // helper function to populate the array lists    
        public static void populateArraylist<T>(IMongoCollection<T> collection, List<T> list)
        {
            foreach (T obj in collection.AsQueryable().ToList())
            {
                list.Add(obj);                
            }
        }
        // return static member variable       
        public static List<BookstoreModel> getBookStoresList()
        {
            return bookStoresList;
        }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ConnectToDb connection = new ConnectToDb();
            
            //MongoClient dbClient = new MongoClient("mongodb://localhost:27017");                   
            //var db = dbClient.GetDatabase("BookstoreDatabase"); // get the database
            //IMongoCollection<BookstoreModel> bookstoresCollection  = db.GetCollection<BookstoreModel>(connDB.getBookStoresCollectionName()); // get the collection / document
            //IMongoCollection<BookModel> booksCollection = db.GetCollection<BookModel>(connDB.getBooksCollectionName()); // get the collection / document

            //populateArraylist(bookstoresCollection, bookStoresList); // populates array list 
            //populateArraylist(booksCollection, booksList); //

            //booksList[0].printBook();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new WelcomeWindow());
            
        }
    }
}