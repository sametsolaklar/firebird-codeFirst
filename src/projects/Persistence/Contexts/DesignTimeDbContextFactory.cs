using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace Persistence.Contexts
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<SampleDbContext>
    {
        public SampleDbContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();
            DbContextOptionsBuilder<SampleDbContext> dbContextOptionBuilder = new();
            dbContextOptionBuilder.UseFirebird(configuration.GetConnectionString("sampleProjectConnectionString"));
            return new SampleDbContext(dbContextOptionBuilder.Options);
        }
    }
}
