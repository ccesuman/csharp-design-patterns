using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Singleton
{
    public class AppSettings
    {
        private static AppSettings? _instance;
        private static readonly object _lock = new object();
        public string DatabaseConnectionString { get; set; }
        public string ApiKey { get; set; }
        private AppSettings()
        {
            // Load settings from configuration file or environment variables
            DatabaseConnectionString = "Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;";
            ApiKey = "12345-ABCDE";
        }
        public static AppSettings Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        _instance ??= new AppSettings();
                    }
                }
                return _instance;
            }
        }
    }

    public class SingletonPattern
    {
        //public static void Main(string[] args)
        //{
        //    AppSettings settings1 = AppSettings.Instance;
        //    AppSettings settings2 = AppSettings.Instance;
        //    Console.WriteLine("Are both instances the same? " + (settings1 == settings2));
        //    Console.WriteLine("Database Connection String: " + settings1.DatabaseConnectionString);
        //    Console.WriteLine("API Key: " + settings1.ApiKey);
        //}
    }
}
