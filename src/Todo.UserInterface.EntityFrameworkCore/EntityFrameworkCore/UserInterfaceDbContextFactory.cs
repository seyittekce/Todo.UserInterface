using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Todo.UserInterface.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class UserInterfaceDbContextFactory : IDesignTimeDbContextFactory<UserInterfaceDbContext>
    {
        public UserInterfaceDbContext CreateDbContext(string[] args)
        {
            UserInterfaceEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<UserInterfaceDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new UserInterfaceDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../Todo.UserInterface.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
