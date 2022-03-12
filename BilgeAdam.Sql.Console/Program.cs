using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using CS = System.Console;
namespace BilgeAdam.Sql.Console
{
    class Program
    {
        private static string connectionString = "Server=localhost, 12000;Database=Northwind;User Id=sa;Password=1q2w3e4R!";
        private static string query = "SELECT CategoryID, CategoryName FROM Categories";
        static void Main(string[] args)
        {
            ConnectV4();

            var cs = Environment.GetEnvironmentVariable("NorthwindConnectionString");
        }

        private static void ConnectV4()
        {
            var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            using (var connection = new SqlConnection(configuration.GetSection("Configuration:Data:NorthwindAddress").Value)) // IDisposable
            {
                connection.Open();
                var command = new SqlCommand(query, connection);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        CS.Write($"{reader[0]}\t");
                        CS.WriteLine(reader["CategoryName"]);
                    }
                }
            }
        }

        private static void ConnectV3()
        {
            var cs = System.Configuration.ConfigurationManager.ConnectionStrings["LocalConnection"].ConnectionString;
            using (var connection = new SqlConnection(cs)) // IDisposable
            {
                connection.Open();
                var command = new SqlCommand(query, connection);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        CS.Write($"{reader[0]}\t");
                        CS.WriteLine(reader["CategoryName"]);
                    }
                }
            }
        }

        private static void ConnectV2()
        {
            // IDisposable olarak belirlenen nesnenin scope bitiminde Dispose methodunu çağırır
            using (var connection = new SqlConnection(connectionString)) // IDisposable
            {
                connection.Open();
                var command = new SqlCommand(query, connection);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        CS.Write($"{reader[0]}\t");
                        CS.WriteLine(reader["CategoryName"]);
                    }
                }
            }
        }

        private static void ConnectV1()
        {
            var connection = new SqlConnection(connectionString);
            connection.Open();
            var command = new SqlCommand(query, connection);
            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                CS.Write($"{reader[0]}\t");
                CS.WriteLine(reader["CategoryName"]);
            }
            reader.Close();
            connection.Close();
            connection.Dispose(); // GC üzerinden sil
        }
    }
}