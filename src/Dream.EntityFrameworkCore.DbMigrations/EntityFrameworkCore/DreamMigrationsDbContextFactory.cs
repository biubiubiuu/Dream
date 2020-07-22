using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Dream.EntityFrameworkCore.DbMigrations.EntityFrameworkCore
{
    public class DreamMigrationsDbContextFactory : IDesignTimeDbContextFactory<DreamMigrationsDbContext>
    {
        public DreamMigrationsDbContext CreateDbContext(string[] args)
        {
            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<DreamMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new DreamMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            return builder.Build();
        }
    }
}