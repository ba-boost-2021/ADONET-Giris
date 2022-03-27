using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Tratel.Data.Managers;

public class ConnectionManager
{
    private static object @lock = new object();
    private static TratelDbContext instance;
    public static TratelDbContext GetDbContext()
    {
        if (instance != null)
        {
            return instance;
        }
        lock (@lock)
        {
            if (instance != null)
            {
                return instance;
            }
            var connectionString = new ConfigurationBuilder()
                        .SetBasePath(Path.Combine(Directory.GetCurrentDirectory()))
                        .AddJsonFile("appSettings.Production.json", false, true).Build()
                        .GetSection("Database:TratelConnectionString").Value;
            var optionsBuilder = new DbContextOptionsBuilder<TratelDbContext>();
            optionsBuilder.UseSqlServer(connectionString);
            var options = optionsBuilder.Options;
            instance = new TratelDbContext(options);
        }
        return instance;
    }
}

// Singleton Pattern
// Nesnenin tek instance ile çalışmasını sağlar

// Data Transfer Object Pattern (Dto)
// İki farklı türdeki scope'Ta veriyi transform ederek taşıma yönetmi sağlar