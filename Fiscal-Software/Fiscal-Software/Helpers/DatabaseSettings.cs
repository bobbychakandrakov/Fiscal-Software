using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Configuration;
using System.Data.SqlClient;

namespace Fiscal_Software.Helpers
{
    public static class DatabaseSettings
    {
        private static bool isSet = false;
        private static string lastConnectionString = "integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";
        private static string lastConnectionString2 = "MultipleActiveResultSets=True;App=EntityFramework";
        private static string connection;

        private static string GetConnectionFromSetting()
        {
            if (File.Exists("settings.txt"))
            {
                return File.ReadAllText("settings.txt");
            }
            return "data source=.";
        }
        public static void SetConnectionString(string conn)
        {
            File.WriteAllText("settings.txt", conn + lastConnectionString);
        }

        public static void SetConnectionString(string server,string catalog)
        {
           
            string conn = "data source=" + server + ";";
            conn += "initial catalog=" + catalog + ";";
            IsSet = IsServerConnected(conn + lastConnectionString);
            if (IsSet)
            {
                
                SetupDatabase(conn + lastConnectionString);
            }
            File.WriteAllText("settings.txt", conn + lastConnectionString);
        }

        public static void SetConnectionString(string server, string catalog, string user , string password)
        {

            string conn = "data source=" + server + ";";
            conn += "initial catalog=" + catalog + ";";
            conn += "integrated Security=true;";
            conn += "User ID=" + user + ";";
            conn += "Password=" + password + ";";
            IsSet = IsServerConnected(conn + lastConnectionString2);
            if (IsSet)
            {
                File.WriteAllText("settings.txt", conn + lastConnectionString);
                SetupDatabase(conn + lastConnectionString);
            }
        }

        public static void SetupDatabase()
        {
            connection = GetConnectionFromSetting();
            IsSet = IsServerConnected(connection);
            if (IsSet)
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.ConnectionStrings.ConnectionStrings["FiscalSoftware"].ConnectionString = connection;
                config.Save(ConfigurationSaveMode.Modified, true);
                ConfigurationManager.RefreshSection("connectionStrings");
            }
        }

        public static void SetupDatabase(string connectionString)
        {
            IsSet = IsServerConnected(connectionString);
            if (IsSet)
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.ConnectionStrings.ConnectionStrings["FiscalSoftware"].ConnectionString = connectionString;
                config.Save(ConfigurationSaveMode.Modified, true);
                ConfigurationManager.RefreshSection("connectionStrings");
                File.WriteAllText("settings.txt", connectionString);
            }
        }

        public static bool IsSet {
            get
            {
                return isSet;
            }
            set
            {
                isSet = value;
            }
        }

        private static bool IsServerConnected(string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    return true;
                }
                catch (SqlException)
                {
                    return false;
                }
            }
        }
    }
}
