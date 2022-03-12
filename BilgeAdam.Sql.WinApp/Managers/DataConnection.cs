using BilgeAdam.Sql.WinApp.Models;
using System.Configuration;
using System.Data.SqlClient;
using System.Text;

namespace BilgeAdam.Sql.WinApp.Managers
{
    internal class DataConnection
    {
        private SqlConnection connection;
        private void Connect()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["LocalConnection"].ConnectionString;
            if (connection == null)
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
            }
        }

        internal IEnumerable<Product> FilterProducts(string productName, bool isInStocks)
{
            var query = new StringBuilder("SELECT ProductId, ProductName, UnitsInStock, UnitPrice FROM Products");
            var conditions = new List<string>();
            if (!string.IsNullOrWhiteSpace(productName))
            {
                conditions.Add($"ProductName LIKE '{productName}%'");
            }
            if (isInStocks)
            {
                conditions.Add("UnitsInStock > 0");
            }
            if (conditions.Count > 0)
            {
                query.Append(" WHERE ");
                query.Append(string.Join(" AND ", conditions));
            }
            Connect();
            var result = FetchProducts(connection, query.ToString());
            Disconnect();
            return result;
        }

        public IEnumerable<Product> LoadProducts()
        {
            Connect();
            var result = FetchProducts(connection, "SELECT ProductId, ProductName, UnitsInStock, UnitPrice FROM Products");
            Disconnect();
            return result;
        }

        private static List<Product> FetchProducts(SqlConnection sqlConnection, string query)
        {
            var result = new List<Product>();
            var command = new SqlCommand(query, sqlConnection);
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    result.Add(new Product
                    {
                        ProductId = reader.GetInt32(0),
                        ProductName = reader.GetString(1),
                        UnitsInStock = reader["UnitsInStock"] != null ? Convert.ToInt32(reader["UnitsInStock"]) : null,
                        UnitPrice = reader["UnitPrice"] != null ? Convert.ToDecimal(reader["UnitPrice"]) : null
                    });
                }
            }
            return result;
        }

        private void Disconnect()
        {
            connection.Close();
            connection.Dispose();
            connection = null;
        }
    }
}
