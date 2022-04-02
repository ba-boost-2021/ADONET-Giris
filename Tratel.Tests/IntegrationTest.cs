using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tratel.Data;

namespace Tratel.Tests
{
    public class IntegrationTest
    {
        [OneTimeSetUp]
        public void SetUp()
        {
            var connectionString = new ConfigurationBuilder()
                        .SetBasePath(Path.Combine(Directory.GetCurrentDirectory()))
                        .AddJsonFile("appSettings.Production.json", false, true).Build()
                        .GetSection("Database:TratelConnectionString").Value;
            var optionsBuilder = new DbContextOptionsBuilder<TratelDbContext>();
            optionsBuilder.UseSqlServer(connectionString);
            var options = optionsBuilder.Options;
            var dbContext = new TratelDbContext(options);
            dbContext.Database.EnsureDeleted();
            dbContext.Database.Migrate();

            var initialSeed = @".\Data\TestDataSeed.sql";
            var content = File.ReadAllText(initialSeed);
            dbContext.Database.ExecuteSqlRaw(content);
        }
    }
}
