using System;
using System.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace DataLibrary
{
    public class DBHelper
    {
        private static Database _database;
        public static DbConnection CreateConnection(Database DB)
        {
            DbConnection conn = DB.CreateConnection();
            conn.Open();
            return conn;
        }
        public static void CloseConnection(DbConnection _conn)
        {
            if (_conn != null && _conn.State == ConnectionState.Open)
                _conn.Close();
        }

        public static Database CreateDatabase()
        {
            //SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            //builder.DataSource = @"(localdb)\MSSQLLocalDB";
            //builder.InitialCatalog = "ProductCatalog";
            //builder.IntegratedSecurity = true;
            //string connectionString = builder.ToString();
            //Database db = new SqlDatabase(connectionString);
            //return db;
            bool encryptionEnabled = false;
            //string connectionString = SecurityHelper.Encrypt(ConfigurationManager.ConnectionStrings["iFoundryDB"].ConnectionString);
            //bool.TryParse(ConfigurationManager.AppSettings["isEncrypted"], out encryptionEnabled);
            return CreateDatabase(encryptionEnabled);
        }

        public static Database CreateDatabase(bool isEncrypted)
        {
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = @"(localdb)\MSSQLLocalDB";
                builder.InitialCatalog = "ifoundry";
                builder.IntegratedSecurity = true;
                //string connectionString = builder.ToString();
                string connectionString = ConfigurationManager.ConnectionStrings["ifoundry"].ConnectionString;
                if (isEncrypted)
                {
                    //string encriptedConnString = SecurityHelper.Decrypt(ConfigurationManager.ConnectionStrings["productcatalog"].ConnectionString);
                    //sb.Password = SecurityHelper.Decrypt(sb.Password);
                    //sb.UserID = SecurityHelper.Decrypt(sb.UserID);
                    //sb.DataSource = SecurityHelper.Decrypt(sb.DataSource);
                    //sb.InitialCatalog = SecurityHelper.Decrypt(sb.InitialCatalog);
                    //connectionString = sb.ToString();
                    //connectionString = encriptedConnString;
                }
                return CreateDatabase(connectionString, isEncrypted);
            }
            catch (Exception ex)
            {
                //LoggingHelper.WriteLog(ex, System.Reflection.MethodBase.GetCurrentMethod().Name);
                throw;
            }
        }
        public static Database CreateDatabase(string connectionString, bool isEncrypted)
        {
            try
            {
                if (_database == null)
                {
                    lock (typeof(Database))
                    {
                        _database = new SqlDatabase(connectionString);
                    }
                }
                return _database;
            }
            catch (Exception ex)
            {
                //LoggingHelper.WriteLog(ex, System.Reflection.MethodBase.GetCurrentMethod().Name);
                throw new Exception("Error reading database details.Error:" + ex.Message);
            }
        }
    }
}
