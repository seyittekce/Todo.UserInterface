using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Todo.UserInterface.Data;
using Volo.Abp.DependencyInjection;

namespace Todo.UserInterface.EntityFrameworkCore
{
    public class EntityFrameworkCoreUserInterfaceDbSchemaMigrator
        : IUserInterfaceDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreUserInterfaceDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;

        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the UserInterfaceDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<UserInterfaceDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}
