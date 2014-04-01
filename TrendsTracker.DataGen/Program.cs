using System;
using System.Configuration;
using System.Data.SqlClient;
using TrendsTracker.Persistence;

namespace TrendsTracker.DataGen
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new PersistenceContext();
            new DbDataDeleter(context).DeleteAllData();
            new DevGenerator(context).Generate();

            Console.ReadKey();
        }
    }
}
