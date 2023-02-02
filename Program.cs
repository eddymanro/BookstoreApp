using MongoDB.Bson;
using MongoDB.Driver;
using System;

namespace BookstoreApp
{
    internal static class Program
    {               
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        { 
            /*
            ConnectToDb connDB = new ConnectToDb();

            MongoClient dbClient = new MongoClient(connDB.getConnectionString());
            var client = new MongoClient();
            var db = client.GetDatabase(connDB.getDatabaseName());
            var collection  = db.GetCollection<BookstoreModel>(connDB.getCollectionName());          
            */
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new WelcomeWindow());
            
        }
    }
}