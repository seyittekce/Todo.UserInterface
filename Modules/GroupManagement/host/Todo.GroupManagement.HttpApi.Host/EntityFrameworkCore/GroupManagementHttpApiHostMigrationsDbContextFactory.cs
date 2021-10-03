using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Todo.GroupManagement.EntityFrameworkCore
{
    public class GroupManagementHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<GroupManagementHttpApiHostMigrationsDbContext>
    {
        public GroupManagementHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
        {
            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<GroupManagementHttpApiHostMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("GroupManagement"));

            return new GroupManagementHttpApiHostMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
