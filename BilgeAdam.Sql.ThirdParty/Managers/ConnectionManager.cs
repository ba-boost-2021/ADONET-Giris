using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace BilgeAdam.Sql.ThirdParty.Managers
{
    public class ConnectionManager
    {
        private SqlConnection connection;
        private void Connect()
        {
            if (connection == null)
            {
                var connectionString = ConfigurationManager.ConnectionStrings["LocalConnection"].ConnectionString;
                connection = new SqlConnection(connectionString);
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
            connection.Dispose();
            connection = null;
        }

        public void RunSelect(string query, Action<SqlDataReader> mapperFunction)
        {
            Connect();
            var command = new SqlCommand(query, connection);
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    mapperFunction(reader);
                }
            }
            Disconnect();
        }

        public T RunAggregation<T>(string query)
        {
            Connect();
            var command = new SqlCommand(query, connection);
            var result = (T)command.ExecuteScalar(); // tek hücreli tablo çıktısı olması lazım (örnek count)
            
            Disconnect();
            return result;
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
