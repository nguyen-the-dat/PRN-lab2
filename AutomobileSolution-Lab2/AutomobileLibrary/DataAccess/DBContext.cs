using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileLibrary.DataAccess
{
    public class DBContext
    {
        public static string GetConnectionString()
        {
            string connectionString;
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsetting.json", true, true).Build();
            connectionString = config["ConStrings:Default"];
            return connectionString;
        }
        //public void CloseConnection() => 


    }
}
