using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Traffic.Data.EF
{
    public class TrafficContextFactory : IDesignTimeDbContextFactory<TrafficDbContext>
    {
        public TrafficDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("DefaultConnection");

            var optionsBuilder = new DbContextOptionsBuilder<TrafficDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new TrafficDbContext(optionsBuilder.Options);
        }
    }
}
