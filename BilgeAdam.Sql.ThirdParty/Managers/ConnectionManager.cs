using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using BilgeAdam.Sql.ThirdParty.HR.Models;
using Dapper;

namespace BilgeAdam.Sql.ThirdParty.Managers
{
    public class ConnectionManager
    {
        private SqlConnection connection;
        public ConnectionManager()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["LocalConnection"].ConnectionString;
            connection = new SqlConnection(connectionString);
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
        }

        private void Disconnect()
        {
            if (connection == null)
            {
                return;
            }
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public List<T> RunSelect<T>(string query)
        {
            var result = connection.Query<T>(query);
            Disconnect();
            return result.ToList();
        }

        public List<T> RunSelect<T>(string query, object parameters)
        {
            var result = connection.Query<T>(query, parameters);
            Disconnect();
            return result.ToList();
        }

        public T RunAggregation<T>(string query)
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
            var command = new SqlCommand(query, connection);
            var result = (T)command.ExecuteScalar(); // tek hücreli tablo çıktısı olması lazım (örnek count)
            
            Disconnect();
            return result;
        }

        public void CreateNew<T>(string query, T data)
        {
            connection.Execute(query, data);
            Disconnect();
        }

        public void Insert(string query, List<SqlParameter> sqlParameters)
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
            var command = new SqlCommand(query, connection);
            command.Parameters.AddRange(sqlParameters.ToArray());
            command.ExecuteNonQuery();
            Disconnect();
        }

        //private List<T> mapperFunction<T>(SqlDataReader a) // -> Func<SqlDataReader, List<T>> mapperFunction
        //{
        //    return null;
        //}

        //private void mapperFunction<T>(SqlDataReader a) // -> Action<SqlDataReader> mapperFunction
        //{
        //    
        //}
    }
}

/*
 class
 struct 
 enum
 interface
 event
 delegate *
 */
