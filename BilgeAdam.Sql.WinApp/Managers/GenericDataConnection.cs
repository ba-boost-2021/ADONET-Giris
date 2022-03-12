using BilgeAdam.Sql.WinApp.Models;
using System.Configuration;
using System.Data.SqlClient;
using System.Reflection;

namespace BilgeAdam.Sql.WinApp.Managers
{
    internal class GenericDataConnection
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

        public List<T> Load<T>(string query) where T : class
        {
            Connect();
            var actualType = typeof(T);
            var result = new List<T>();
            var command = new SqlCommand(query, connection);
            using (var reader = command.ExecuteReader())
            {
                var properties = actualType.GetProperties(BindingFlags.Public | BindingFlags.Instance);
                while (reader.Read())
                {
                    var instance = Activator.CreateInstance<T>();
                    foreach (var property in properties)
                    {
                        var readerValue = reader[property.Name];
                        //var propertyType = Nullable.GetUnderlyingType(property.PropertyType) != null ? Nullable.GetUnderlyingType(property.PropertyType) : property.PropertyType;
                        var propertyType = Nullable.GetUnderlyingType(property.PropertyType) ?? property.PropertyType; // COALESCE
                        var safeValue = readerValue == null ? null : Convert.ChangeType(readerValue, propertyType);
                        property.SetValue(instance, safeValue);
                    }
                    result.Add(instance);
                }
            }
            Disconnect();
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
