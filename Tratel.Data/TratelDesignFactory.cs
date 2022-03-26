using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tratel.Data
{
    public class TratelDesignFactory : IDesignTimeDbContextFactory<TratelDbContext>
    {
        public TratelDbContext CreateDbContext(string[] args)
        {
            var connectionString = new ConfigurationBuilder()
                        .SetBasePath(Path.Combine(Directory.GetCurrentDirectory()))
                        .AddJsonFile("appSettings.json", false, true).Build()
                        .GetSection("Local").Value;
            var optionsBuilder = new DbContextOptionsBuilder<TratelDbContext>();
            optionsBuilder.UseSqlServer(connectionString);
            var options = optionsBuilder.Options;
            return new TratelDbContext(options);
        }
    }
}
