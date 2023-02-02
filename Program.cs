using MongoDB.Bson;
using MongoDB.Driver;

namespace BookstoreApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        // [STAThread]
        static void Main()
        {
            var client = new MongoClient();
            var db = client.GetDatabase("BookstoreDatabase");


            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new WelcomeWindow());
        }
    }
}