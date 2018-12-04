using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;

namespace DataLibrary
{
    public class DBProvider
    {
        public static Database CreateDatabase(string connectionStringName, bool isEncrypted = false)
        {
            try
            {
                ConnectionStringSettings settings = WebConfigurationManager.ConnectionStrings[connectionStringName];
                string decryptedConnectionString;
                if (isEncrypted)
                {
                    decryptedConnectionString = DecryptConnectionString(settings.ConnectionString);
                }
                else
                {
                    decryptedConnectionString = settings.ConnectionString;
                }
                Database database = GetDatabase(settings.ProviderName, decryptedConnectionString);
                return database;
            }
            catch (Exception ex)
            {
                throw new Exception("Error reading database details. Error:" + ex.Message);
            }
        }

        private static Database GetDatabase(string providerName, string decryptedConnectionString)
        {
            Database database;
            switch (providerName)
            {
                case "System.Data.SqlClient":
                    database = new SqlDatabase(decryptedConnectionString);
                    break;
                case "MySql.Data.MySqlClient":
                default:
                    DbProviderFactory factory = DbProviderFactories.GetFactory(providerName);
                    database = new GenericDatabase(decryptedConnectionString, factory);
                    break;
            }
            return database;
        }

        private static string DecryptConnectionString(string encryptedConnectionString)
        {
            throw new NotImplementedException("Decryption not yet implemented");
        }
    }
}
