using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using Dapper;

namespace ICMDataManager.Library.Internal.DataAccess
{
    internal class SqlDataAccess
    {
        //internal 
        //don't want anything outside dll to be able to use it , to connect directly to db
        public string GetConnectionString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
        public List<T> LoadData<T, U>(string storedProcedure, U parameters, string connectionStringName)
        {
            string connectionString = GetConnectionString(connectionStringName);

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                //Take the connection string (connection)
                //Query<T> generic type model that i want each row to be 
                //pass storedProcedure by name , parameters type U (also generic)
                //and connectionStringName to get full connection string by using GetConnectionString method
                //and asign it storedProcedure type and return all rows

                List<T> rows = connection.Query<T>(storedProcedure, parameters,
                    commandType: CommandType.StoredProcedure).ToList();

                return rows;
            }
        }

        //T U V W usual name for generics thats why T here is a generic
        public void SaveData<T>(string storedProcedure, T parameters, string connectionStringName)
        {
            string connectionString = GetConnectionString(connectionStringName);

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                //async?
                //-----> do it later
                connection.Execute(storedProcedure, parameters,
                    commandType: CommandType.StoredProcedure);
            }
        }
    }
}
