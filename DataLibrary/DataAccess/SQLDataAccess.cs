using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataLibrary.DataAccess
{
    public static class SQLDataAccess
    {
        public static string GetConnectionString(string connectionName = "TechnicalTeshDB")
        {
            // Get connection string for TechnicalTestDB
            return ConfigurationManager.ConnectionStrings[connectionName].ConnectionString;
        }

        // Pass in SQL string into model <T>
        public static List<T> LoadData<T>(string sql)
        {
            // cnn is the open connection to the database
            using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
            {
                // return DB response as List instead of IEnumerable
                return cnn.Query<T>(sql).ToList();
            }
        }
 
        public static int SaveData<T>(string sql, T data)
        {
            using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
            {
                // return number of records returned as int
                return cnn.Execute(sql, data);
            }
        }
    }
}
