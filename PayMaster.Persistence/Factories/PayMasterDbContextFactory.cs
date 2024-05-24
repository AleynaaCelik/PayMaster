using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using PayMaster.Persistence.Contexts;
using System.IO;

namespace PayMaster.Persistence.Factories
{
    public class PayMasterDbContextFactory : IDesignTimeDbContextFactory<PayMasterDbContext>
    {
        public PayMasterDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<PayMasterDbContext>();

            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath($"{Directory.GetParent(Directory.GetCurrentDirectory())}/PayMaster.Presentation")
                .AddJsonFile("appsettings.json")
                .Build();

            // Get connection string
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            // Configure the DbContext to use PostgreSQL or any other provider
            optionsBuilder.UseNpgsql(connectionString); // PostgreSQL İçin
            

            return new PayMasterDbContext(optionsBuilder.Options);
        }
    }
}
