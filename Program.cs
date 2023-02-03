using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using System;
using System.Runtime.CompilerServices;

namespace BookstoreApp
{
    internal static class Program
    {        
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

        // clear for static method
        public static void clearList<T>(List<T> list)
        {
            list.Clear();
        }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {                   
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new WelcomeWindow());

            // testing stuff
            //bookStoresList[2].printBookstore();

        }
    }
}